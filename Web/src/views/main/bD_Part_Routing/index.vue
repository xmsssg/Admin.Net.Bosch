<template>
	<div class="bD_Part_Routing-container">
		<el-card shadow="hover" :body-style="{ paddingBottom: '0' }">
			<el-form :model="queryParams" ref="queryForm" :inline="true">
			<el-row :gutter="35">
              <el-col :xs="24" :sm="12" :md="8" :lg="6" :xl="6" >
              <el-form-item label="产品工序版本号">
              <el-input v-model="queryParams.partRoutingNo" clearable placeholder="请输入产品工序版本号"/>
              </el-form-item>
              </el-col>
              <el-col :xs="24" :sm="12" :md="8" :lg="6" :xl="6" >
              <el-form-item label="产品工序版本名称">
              <el-input v-model="queryParams.partRoutingName" clearable placeholder="请输入产品工序版本名称"/>
              </el-form-item>
              </el-col>
          <el-col :xs="24" :sm="24" :md="24" :lg="24" :xl="24" class="mb20 search-actions">
          <div><el-button type="primary" icon="ele-Plus" @click="openAddBD_Part_Routing" v-auth="'bD_Part_Routing:add'"> 新增 </el-button></div>
          <div>
          <el-button icon="ele-Refresh" @click="() => queryParams = {}"> 重置 </el-button>
          <el-button type="primary" plain icon="ele-Search" @click="handleQuery" v-auth="'bD_Part_Routing:page'"> 查询 </el-button>
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
				 <el-table-column prop="partRoutingNo" label="产品工序版本号" fixed="" show-overflow-tooltip="" />
				 <el-table-column prop="partRoutingName" label="产品工序版本名称" fixed="" show-overflow-tooltip="" />
				<el-table-column label="操作" width="140" align="center" fixed="right" show-overflow-tooltip="" v-if="auth('bD_Part_Routing:edit') || auth('bD_Part_Routing:delete')">
					<template #default="scope">
						<el-button icon="ele-Edit" size="small" text="" type="primary" @click="openEditBD_Part_Routing(scope.row)" v-auth="'bD_Part_Routing:edit'"> 编辑 </el-button>
						<el-button icon="ele-Delete" size="small" text="" type="primary" @click="delBD_Part_Routing(scope.row)" v-auth="'bD_Part_Routing:delete'"> 删除 </el-button>
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
			    :title="editBD_Part_RoutingTitle"
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

	import editDialog from '/@/views/main/bD_Part_Routing/component/editDialog.vue'
	import { pageBD_Part_Routing, deleteBD_Part_Routing } from '/@/api/main/bD_Part_Routing';


		const editDialogRef = ref();
		const loading = ref(false);
		const tableData = ref<any>([]);
const queryParams = ref<any>
  ({});
  const tableParams = ref({
  page: 1,
  pageSize: 10,
  total: 0,
  });
  const editBD_Part_RoutingTitle = ref("");


  // 查询操作
  const handleQuery = async () => {
  loading.value = true;
  var res = await pageBD_Part_Routing(Object.assign(queryParams.value, tableParams.value));
  tableData.value = res.data.result?.items ?? [];
  tableParams.value.total = res.data.result?.total;
  loading.value = false;
  };

  // 打开新增页面
  const openAddBD_Part_Routing = () => {
  editBD_Part_RoutingTitle.value = '添加调度Routing信息';
  editDialogRef.value.openDialog({});
  };

  // 打开编辑页面
  const openEditBD_Part_Routing = (row: any) => {
  editBD_Part_RoutingTitle.value = '编辑调度Routing信息';
  editDialogRef.value.openDialog({...row});
  };

  // 删除
  const delBD_Part_Routing = (row: any) => {
  ElMessageBox.confirm(`确定要删除吗?`, "提示", {
  confirmButtonText: "确定",
  cancelButtonText: "取消",
  type: "warning",
  })
  .then(async () => {
  await deleteBD_Part_Routing(row);
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


