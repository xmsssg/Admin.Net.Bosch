<template>
	<div class="bD_Stock-container">
		<el-card shadow="hover" :body-style="{ paddingBottom: '0' }">
			<el-form :model="queryParams" ref="queryForm" :inline="true">
			<el-row :gutter="35">
              <el-col :xs="24" :sm="12" :md="8" :lg="6" :xl="6" >
              <el-form-item label="产品编码">
              <el-input v-model="queryParams.partNo" clearable placeholder="请输入产品编码"/>
              </el-form-item>
              </el-col>
              <el-col :xs="24" :sm="12" :md="8" :lg="6" :xl="6" >
              <el-form-item label="Batch">
              <el-input v-model="queryParams.batch" clearable placeholder="请输入Batch"/>
              </el-form-item>
              </el-col>
              <el-col :xs="24" :sm="12" :md="8" :lg="6" :xl="6" >
              <el-form-item label="可用库存">
              <el-input v-model="queryParams.availableStock" clearable placeholder="请输入可用库存"/>
              </el-form-item>
              </el-col>
              <el-col :xs="24" :sm="12" :md="8" :lg="6" :xl="6" >
              <el-form-item label="当前库存">
              <el-input v-model="queryParams.currentStock" clearable placeholder="请输入当前库存"/>
              </el-form-item>
              </el-col>
              <el-col :xs="24" :sm="12" :md="8" :lg="6" :xl="6" >
              <el-form-item label="位置">
              <el-input v-model="queryParams.location" clearable placeholder="请输入位置"/>
              </el-form-item>
              </el-col>
              <el-col :xs="24" :sm="12" :md="8" :lg="6" :xl="6" >
              <el-form-item label="容器Bin">
              <el-input v-model="queryParams.bin" clearable placeholder="请输入容器Bin"/>
              </el-form-item>
              </el-col>
              <el-col :xs="24" :sm="12" :md="8" :lg="6" :xl="6" >
              <el-form-item label="已弃用Serial">
              <el-input v-model="queryParams.serial" clearable placeholder="请输入已弃用Serial"/>
              </el-form-item>
              </el-col>
              <el-col :xs="24" :sm="12" :md="8" :lg="6" :xl="6" >
              <el-form-item label="已弃用Serial">
              <el-input v-model="queryParams.aTPQty" clearable placeholder="请输入已弃用Serial"/>
              </el-form-item>
              </el-col>
              <el-col :xs="24" :sm="12" :md="8" :lg="6" :xl="6" >
              <el-form-item label="可使用量">
              <el-input v-model="queryParams.availableQOH" clearable placeholder="请输入可使用量"/>
              </el-form-item>
              </el-col>
              <el-col :xs="24" :sm="12" :md="8" :lg="6" :xl="6" >
              <el-form-item label="是否是原材料">
              <el-input-number v-model="queryParams.isRawMaterial"  clearable placeholder="请输入是否是原材料"/>
              </el-form-item>
              </el-col>
              <el-col :xs="24" :sm="12" :md="8" :lg="6" :xl="6" >
              <el-form-item label="最小批量">
              <el-input-number v-model="queryParams.lotSize"  clearable placeholder="请输入最小批量"/>
              </el-form-item>
              </el-col>
          <el-col :xs="24" :sm="24" :md="24" :lg="24" :xl="24" class="mb20 search-actions">
          <div><el-button type="primary" icon="ele-Plus" @click="openAddBD_Stock" v-auth="'bD_Stock:add'"> 新增 </el-button></div>
          <div>
          <el-button icon="ele-Refresh" @click="() => queryParams = {}"> 重置 </el-button>
          <el-button type="primary" plain icon="ele-Search" @click="handleQuery" v-auth="'bD_Stock:page'"> 查询 </el-button>
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
				 <el-table-column prop="partNo" label="产品编码" fixed="" show-overflow-tooltip="" />
				 <el-table-column prop="batch" label="Batch" fixed="" show-overflow-tooltip="" />
				 <el-table-column prop="availableStock" label="可用库存" fixed="" show-overflow-tooltip="" />
				 <el-table-column prop="currentStock" label="当前库存" fixed="" show-overflow-tooltip="" />
				 <el-table-column prop="location" label="位置" fixed="" show-overflow-tooltip="" />
				 <el-table-column prop="bin" label="容器Bin" fixed="" show-overflow-tooltip="" />
				 <el-table-column prop="serial" label="已弃用Serial" fixed="" show-overflow-tooltip="" />
				 <el-table-column prop="aTPQty" label="已弃用Serial" fixed="" show-overflow-tooltip="" />
				 <el-table-column prop="availableQOH" label="可使用量" fixed="" show-overflow-tooltip="" />
				 <el-table-column prop="isRawMaterial" label="是否是原材料" fixed="" show-overflow-tooltip="" />
				 <el-table-column prop="lotSize" label="最小批量" fixed="" show-overflow-tooltip="" />
				<el-table-column label="操作" width="140" align="center" fixed="right" show-overflow-tooltip="" v-if="auth('bD_Stock:edit') || auth('bD_Stock:delete')">
					<template #default="scope">
						<el-button icon="ele-Edit" size="small" text="" type="primary" @click="openEditBD_Stock(scope.row)" v-auth="'bD_Stock:edit'"> 编辑 </el-button>
						<el-button icon="ele-Delete" size="small" text="" type="primary" @click="delBD_Stock(scope.row)" v-auth="'bD_Stock:delete'"> 删除 </el-button>
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
			    :title="editBD_StockTitle"
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

	import editDialog from '/@/views/main/bD_Stock/component/editDialog.vue'
  import { getAPI } from '/@/utils/axios-utils';
  import { BDStockApi } from '/@/api-services/api';


		const editDialogRef = ref();
		const loading = ref(false);
		const tableData = ref<any>([]);
const queryParams = ref<any>
  ({});
  const tableParams = ref({
  page: 1,
  pageSize: 10,
  total:0 as any,
  });
  const editBD_StockTitle = ref("");


  // 查询操作
  const handleQuery = async () => {
  loading.value = true;
  var res = await getAPI(BDStockApi).apiBDStockPagePost(Object.assign(queryParams.value, tableParams.value));
  tableData.value = res.data.result?.items ?? [];
  tableParams.value.total = res.data.result?.total;
  loading.value = false;
  };

  // 打开新增页面
  const openAddBD_Stock = () => {
  editBD_StockTitle.value = '添加库存信息';
  editDialogRef.value.openDialog({});
  };

  // 打开编辑页面
  const openEditBD_Stock = (row: any) => {
  editBD_StockTitle.value = '编辑库存信息';
  editDialogRef.value.openDialog({...row});
  };

  // 删除
  const delBD_Stock = (row: any) => {
  ElMessageBox.confirm(`确定要删除吗?`, "提示", {
  confirmButtonText: "确定",
  cancelButtonText: "取消",
  type: "warning",
  })
  .then(async () => {
  await getAPI(BDStockApi).apiBDStockDeletePost(row);
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


