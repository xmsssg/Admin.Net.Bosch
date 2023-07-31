<template>
	<div class="bD_Resource-container">
		<el-card shadow="hover" :body-style="{ paddingBottom: '0' }">
			<el-form :model="queryParams" ref="queryForm" :inline="true">
			<el-row :gutter="35">
              <el-form-item label="工作中心编号">
              <el-input v-model="queryParams.workCenterNo" clearable placeholder="请输入工作中心编号"/>
              </el-form-item>
              <el-form-item label="设备编码">
              <el-input v-model="queryParams.resNo" clearable placeholder="请输入资源设备编码"/>
              </el-form-item>
              <el-form-item label="设备名称">
              <el-input v-model="queryParams.resName" clearable placeholder="请输入资源设备名称"/>
              </el-form-item>
              <el-form-item label="设备描述">
              <el-input v-model="queryParams.resDesc" clearable placeholder="请输入设备描述"/>
              </el-form-item>
              <el-form-item label="设备是否可用">
              <el-input-number v-model="queryParams.isAvailable"  clearable placeholder="请输入设备是否可用"/>
              </el-form-item>
          <el-col :xs="24" :sm="24" :md="24" :lg="24" :xl="24" class="mb20 search-actions">
          <div>
            <el-button type="primary" icon="ele-Plus" @click="openAddBD_Resource" v-auth="'bD_Resource:add'"> 新增 </el-button>
            <el-button icon="ele-Refresh" @click="() => queryParams = {}"> 重置 </el-button>
            <el-button type="primary" plain icon="ele-Search" @click="handleQuery" v-auth="'bD_Resource:page'"> 查询 </el-button>
          </div>
          </el-col>
      </el-row>
      </el-form>
		</el-card>
		<el-card shadow="hover" style="margin-top: 8px">
			<el-table
				:data="tableData"
				style="width: 100%"
				v-loading="loading"
				tooltip-effect="light"
				row-key="id"
				border="">
				<!-- <el-table-column type="index" label="序号" width="55" align="center" /> -->
				 <el-table-column prop="workCenterNo" label="工作中心编号" fixed="" show-overflow-tooltip="" />
				 <el-table-column prop="resNo" label="设备编码" fixed="" show-overflow-tooltip="" />
				 <el-table-column prop="resName" label="设备名称" fixed="" show-overflow-tooltip="" />
				 <el-table-column prop="resDesc" label="设备描述" fixed="" show-overflow-tooltip="" />
         <el-table-column label="设备类型" fixed="" show-overflow-tooltip="">
					<template #default="scope">
						{{scope.row.type=='1'?'内部':scope.row.type=='2'?'外部':'外协' }}
					</template>
				</el-table-column>	
         <el-table-column label="设备产能类型" fixed="" show-overflow-tooltip="">
					<template #default="scope">
						{{scope.row.resType=='-1'?'无限产能':scope.row.resType=='0'?'单产能':'多产能' }}
					</template>
				</el-table-column>	
				 <el-table-column prop="units" label="设备数量" fixed="" show-overflow-tooltip="" />
         <el-table-column label="设备是否可用" fixed="" show-overflow-tooltip="">
					<template #default="scope">
						{{scope.row.isAvailable=='1'?'Y':'N' }}
					</template>
				</el-table-column>	
				<el-table-column label="操作" width="140" align="center" fixed="right" show-overflow-tooltip="" v-if="auth('bD_Resource:edit') || auth('bD_Resource:delete')">
					<template #default="scope">
						<el-button icon="ele-Edit" size="small" text="" type="primary" @click="openEditBD_Resource(scope.row)" v-auth="'bD_Resource:edit'"> 编辑 </el-button>
						<el-button icon="ele-Delete" size="small" text="" type="primary" @click="delBD_Resource(scope.row)" v-auth="'bD_Resource:delete'"> 删除 </el-button>
					</template>
				</el-table-column>
			</el-table>
			<el-pagination
				v-model:currentPage="tableParams.page"
				v-model:page-size="tableParams.pageSize"
				:total="tableParams.total"
				:page-sizes="[10, 20, 50, 100]"
				small=""
				background=""
				@size-change="handleSizeChange"
				@current-change="handleCurrentChange"
				layout="total, sizes, prev, pager, next, jumper"
	/>
			<editDialog
			    ref="editDialogRef"
			    :title="editBD_ResourceTitle"
			    @reloadTable="handleQuery"
      />
		</el-card>
	</div>
</template>

<script lang="ts" setup>
	import { ref } from "vue";
	import { ElMessageBox, ElMessage } from "element-plus";
	import { auth } from '/@/utils/authFunction';
	//import { formatDate } from '/@/utils/formatTime';

	import editDialog from '/@/views/main/bD_Resource/component/editDialog.vue'

  import { getAPI } from '/@/utils/axios-utils';
import { BDResourceApi } from '/@/api-services/api';

		const editDialogRef = ref();
		const loading = ref(false);
		const tableData = ref<any>([]);
const queryParams = ref<any>
  ({});
  const tableParams = ref({
  page: 1,
  pageSize: 50,
  total: 0 as any,
  });
  const editBD_ResourceTitle = ref("");


  // 查询操作
  const handleQuery = async () => {
  loading.value = true;
  var res = await getAPI(BDResourceApi).apiBDResourcePagePost(Object.assign(queryParams.value, tableParams.value));
  tableData.value = res.data.result?.items ?? [];
  tableParams.value.total = res.data.result?.total;
  loading.value = false;
  };

  // 打开新增页面
  const openAddBD_Resource = () => {
  editBD_ResourceTitle.value = '添加资源设备信息';
  editDialogRef.value.openDialog({});
  };

  // 打开编辑页面
  const openEditBD_Resource = (row: any) => {
  editBD_ResourceTitle.value = '编辑资源设备信息';
  editDialogRef.value.openDialog({...row});
  };

  // 删除
  const delBD_Resource = (row: any) => {
  ElMessageBox.confirm(`确定要删除吗?`, "提示", {
  confirmButtonText: "确定",
  cancelButtonText: "取消",
  type: "warning",
  })
  .then(async () => {
  await getAPI(BDResourceApi).apiBDResourceDeletePost(row);
  handleQuery();
  ElMessage.success("删除成功");
  })
  .catch(() => {});
  };

  // 改变页面容量
  const handleSizeChange = (val: number) => {
  tableParams.value.pageSize = val;
  handleQuery();
  };

  // 改变页码序号
  const handleCurrentChange = (val: number) => {
  tableParams.value.page = val;
  handleQuery();
  };


handleQuery();
</script>


