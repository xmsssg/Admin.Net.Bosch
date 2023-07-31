<template>
	<div class="bD_CalendarGeneral-container">
		<el-card shadow="hover" :body-style="{ paddingBottom: '0' }">
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
				 <el-table-column prop="calNo" label="日历编码" fixed="" show-overflow-tooltip="" />
				 <el-table-column prop="calName" label="日历名称" fixed="" show-overflow-tooltip="" />
				 <el-table-column prop="beginDate" label="可用开始时间" fixed="" show-overflow-tooltip="" />
				 <el-table-column prop="endDate" label="可用结束时间" fixed="" show-overflow-tooltip="" />
				 <el-table-column prop="workDay" label="工作日" fixed="" show-overflow-tooltip="" />
				 <el-table-column prop="shift1" label="班次1" fixed="" show-overflow-tooltip="" />
				 <el-table-column prop="shift2" label="班次2" fixed="" show-overflow-tooltip="" />
				 <el-table-column prop="shift3" label="班次3" fixed="" show-overflow-tooltip="" />
				<el-table-column label="操作" width="140" align="center" fixed="right" show-overflow-tooltip="" v-if="auth('bD_CalendarGeneral:edit') || auth('bD_CalendarGeneral:delete')">
					<template #default="scope">
						<el-button icon="ele-Edit" size="small" text="" type="primary" @click="openEditBD_CalendarGeneral(scope.row)" v-auth="'bD_CalendarGeneral:edit'"> 编辑 </el-button>
						<el-button icon="ele-Delete" size="small" text="" type="primary" @click="delBD_CalendarGeneral(scope.row)" v-auth="'bD_CalendarGeneral:delete'"> 删除 </el-button>
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
			    :title="editBD_CalendarGeneralTitle"
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

	import editDialog from '/@/views/main/bD_CalendarGeneral/component/editDialog.vue'
  	import { getAPI } from '/@/utils/axios-utils';
  	import { BDCalendarGeneralApi } from '/@/api-services/api';


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
  const editBD_CalendarGeneralTitle = ref("");


  // 查询操作
  const handleQuery = async () => {
  loading.value = true;
  var res = await getAPI(BDCalendarGeneralApi).apiBDCalendarGeneralPagePost(Object.assign(queryParams.value, tableParams.value));
  tableData.value = res.data.result?.items ?? [];
  tableParams.value.total = res.data.result?.total;
  loading.value = false;
  };

  // 打开新增页面
  const openAddBD_CalendarGeneral = () => {
  editBD_CalendarGeneralTitle.value = '添加日历信息';
  editDialogRef.value.openDialog({});
  };

  // 打开编辑页面
  const openEditBD_CalendarGeneral = (row: any) => {
  editBD_CalendarGeneralTitle.value = '编辑日历信息';
  editDialogRef.value.openDialog({...row});
  };

  // 删除
  const delBD_CalendarGeneral = (row: any) => {
  ElMessageBox.confirm(`确定要删除吗?`, "提示", {
  confirmButtonText: "确定",
  cancelButtonText: "取消",
  type: "warning",
  })
  .then(async () => {
  await getAPI(BDCalendarGeneralApi).apiBDCalendarGeneralDeletePost(row);
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


