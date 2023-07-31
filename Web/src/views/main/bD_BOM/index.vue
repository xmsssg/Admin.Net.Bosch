<template>
	<div class="bD_BOM-container">
		<el-card shadow="hover" :body-style="{ paddingBottom: '0' }">
			<el-form :model="queryParams" ref="queryForm" :inline="true">
			<el-row :gutter="35">
              <el-col :xs="24" :sm="12" :md="8" :lg="6" :xl="6" >
              <el-form-item label="主产品Id">
              <el-input v-model="queryParams.masterPartId" clearable placeholder="请输入主产品Id"/>
              </el-form-item>
              </el-col>
              <el-col :xs="24" :sm="12" :md="8" :lg="6" :xl="6" >
              <el-form-item label="主产品Id">
              <el-input v-model="queryParams.subPartId" clearable placeholder="请输入主产品Id"/>
              </el-form-item>
              </el-col>
              <el-col :xs="24" :sm="12" :md="8" :lg="6" :xl="6" >
              <el-form-item label="根产成品Id">
              <el-input v-model="queryParams.rootPartId" clearable placeholder="请输入根产成品Id"/>
              </el-form-item>
              </el-col>
              <el-col :xs="24" :sm="12" :md="8" :lg="6" :xl="6" >
              <el-form-item label="比例">
              <el-input v-model="queryParams.needQty" clearable placeholder="请输入比例"/>
              </el-form-item>
              </el-col>
              <el-col :xs="24" :sm="12" :md="8" :lg="6" :xl="6" >
              <el-form-item label="层级">
              <el-input-number v-model="queryParams.level"  clearable placeholder="请输入层级"/>
              </el-form-item>
              </el-col>
          <el-col :xs="24" :sm="24" :md="24" :lg="24" :xl="24" class="mb20 search-actions">
          <div><el-button type="primary" icon="ele-Plus" @click="openAddBD_BOM" v-auth="'bD_BOM:add'"> 新增 </el-button></div>
          <div>
          <el-button icon="ele-Refresh" @click="() => queryParams = {}"> 重置 </el-button>
          <el-button type="primary" plain icon="ele-Search" @click="handleQuery" v-auth="'bD_BOM:page'"> 查询 </el-button>
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
				<el-table-column type="index" label="序号" width="55" align="center" />
				 <el-table-column prop="masterPartId" label="主产品Id" fixed="" show-overflow-tooltip="" />
				 <el-table-column prop="subPartId" label="主产品Id" fixed="" show-overflow-tooltip="" />
				 <el-table-column prop="rootPartId" label="根产成品Id" fixed="" show-overflow-tooltip="" />
				 <el-table-column prop="needQty" label="比例" fixed="" show-overflow-tooltip="" />
				 <el-table-column prop="level" label="层级" fixed="" show-overflow-tooltip="" />
				<el-table-column label="操作" width="140" align="center" fixed="right" show-overflow-tooltip="" v-if="auth('bD_BOM:edit') || auth('bD_BOM:delete')">
					<template #default="scope">
						<el-button icon="ele-Edit" size="small" text="" type="primary" @click="openEditBD_BOM(scope.row)" v-auth="'bD_BOM:edit'"> 编辑 </el-button>
						<el-button icon="ele-Delete" size="small" text="" type="primary" @click="delBD_BOM(scope.row)" v-auth="'bD_BOM:delete'"> 删除 </el-button>
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
			    :title="editBD_BOMTitle"
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

	import editDialog from '/@/views/main/bD_BOM/component/editDialog.vue'
	// import { pageBD_BOM, deleteBD_BOM } from '/@/api/main/bD_BOM';

  import { getAPI } from '/@/utils/axios-utils';
import { BDBOMApi } from '/@/api-services/api';

		const editDialogRef = ref();
		const loading = ref(false);
		const tableData = ref<any>([]);
const queryParams = ref<any>
  ({});
  const tableParams = ref({
  page: 1,
  pageSize: 10,
  total: 0 as any,
  });
  const editBD_BOMTitle = ref("");


  // 查询操作
  const handleQuery = async () => {
  loading.value = true;
  var res = await getAPI(BDBOMApi).apiBDBOMPagePost(Object.assign(queryParams.value, tableParams.value));
  tableData.value = res.data.result?.items ?? [];
  tableParams.value.total = res.data.result?.total;
  loading.value = false;
  };

  // 打开新增页面
  const openAddBD_BOM = () => {
  editBD_BOMTitle.value = '添加BOM信息';
  editDialogRef.value.openDialog({});
  };

  // 打开编辑页面
  const openEditBD_BOM = (row: any) => {
  editBD_BOMTitle.value = '编辑BOM信息';
  editDialogRef.value.openDialog({...row});
  };

  // 删除
  const delBD_BOM = (row: any) => {
  ElMessageBox.confirm(`确定要删除吗?`, "提示", {
  confirmButtonText: "确定",
  cancelButtonText: "取消",
  type: "warning",
  })
  .then(async () => {
  await await getAPI(BDBOMApi).apiBDBOMDeletePost(row);
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


