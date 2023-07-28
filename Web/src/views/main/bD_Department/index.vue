<template>
	<div class="bD_Department-container">
		<el-card shadow="hover" :body-style="{ paddingBottom: '0' }">
			<el-form :model="queryParams" ref="queryForm" :inline="true">
			<el-row :gutter="35">
              <el-form-item label="部门编号">
              	<el-input v-model="queryParams.depNo" clearable placeholder="请输入部门编号"/>
              </el-form-item>
              <el-form-item label="部门名称">
              	<el-input v-model="queryParams.depName" clearable placeholder="请输入部门名称"/>
              </el-form-item>
              <el-form-item label="部门类型">
              	<!-- <el-input v-model="queryParams.remarks" clearable/> -->
				  <el-select v-model="queryParams.remarks" class="m-2" placeholder="" size="small">
					<el-option
					v-for="item in options"
					:key="item.value"
					:label="item.label"
					:value="item.value"
					/>
			  </el-select>
              </el-form-item>
          <el-button icon="ele-Refresh" @click="() => queryParams = {}"> 重置 </el-button>
          <el-button type="primary" plain icon="ele-Search" @click="handleQuery" v-auth="'bD_Department:page'"> 查询 </el-button>
		  <el-button type="primary" icon="ele-Plus" @click="openAddBD_Department" v-auth="'bD_Department:add'"> 新增 </el-button>
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
				 <!-- <el-table-column prop="depId" label="部门Id，唯一标识" fixed="" show-overflow-tooltip="" /> -->
				 <!-- <el-table-column prop="workshopId" label="部门WorkshopId" fixed="" show-overflow-tooltip="" /> -->
				 <el-table-column prop="depNo" label="部门编号" fixed="" show-overflow-tooltip="" />
				 <el-table-column prop="depName" label="部门名称" fixed="" show-overflow-tooltip="" />
				 <el-table-column prop="depDesc" label="部门描述" fixed="" show-overflow-tooltip="" />
				 <!-- <el-table-column prop="status" label="部门状态，默认为1" fixed="" show-overflow-tooltip="" /> -->
				 <el-table-column label="部门类型" fixed="" show-overflow-tooltip="">
					<template #default="scope">
						{{scope.row.remarks=='1'?'制造':'非制造' }}
					</template>
				</el-table-column>	
				 
				 <!-- <el-table-column prop="orgID" label="组织OrgId" fixed="" show-overflow-tooltip="" /> -->
				<el-table-column label="操作" width="140" align="center" fixed="right" show-overflow-tooltip="" v-if="auth('bD_Department:edit') || auth('bD_Department:delete')">
					<template #default="scope">
						<el-button icon="ele-Edit" size="small" text="" type="primary" @click="openEditBD_Department(scope.row)" v-auth="'bD_Department:edit'"> 编辑 </el-button>
						<el-button icon="ele-Delete" size="small" text="" type="primary" @click="delBD_Department(scope.row)" v-auth="'bD_Department:delete'"> 删除 </el-button>
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
			    :title="editBD_DepartmentTitle"
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

	import editDialog from '/@/views/main/bD_Department/component/editDialog.vue'
	import { pageBD_Department, deleteBD_Department } from '/@/api/main/bD_Department';

	import { getAPI } from '/@/utils/axios-utils';
	import { BDDepartmentApi } from '/@/api-services/api';

		const editDialogRef = ref();
		const loading = ref(false);
		const tableData = ref<any>([]);
const queryParams = ref<any>
	({});
	const tableParams = ref({
	page: 1,
	pageSize: 10,
	total:  0 as any,
	});
	const editBD_DepartmentTitle = ref("");


	// 查询操作
	const handleQuery = async () => {
	loading.value = true;
	var res = await getAPI(BDDepartmentApi).apiBDDepartmentPagePost(Object.assign(queryParams.value, tableParams.value));
	tableData.value = res.data.result?.items ?? [];
	tableParams.value.total = res.data.result?.total;
	loading.value = false;
	};

	// 打开新增页面
	const openAddBD_Department = () => {
	editBD_DepartmentTitle.value = '添加部门信息';
	editDialogRef.value.openDialog({});
	};

	// 打开编辑页面
	const openEditBD_Department = (row: any) => {
	editBD_DepartmentTitle.value = '编辑部门信息';
	editDialogRef.value.openDialog(row);
	};

	// 删除
	const delBD_Department = (row: any) => {
	ElMessageBox.confirm(`确定要删除吗?`, "提示", {
	confirmButtonText: "确定",
	cancelButtonText: "取消",
	type: "warning",
	})
	.then(async () => {
	await getAPI(BDDepartmentApi).apiBDDepartmentDeletePost(row);
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
const options = [
  {
    value: '1',
    label: '制造',
  },
  {
    value: '0',
    label: '非制造',
  }
]
</script>


