<template>
	<div class="bD_Stock-container">
		<el-dialog v-model="isShowDialog" :title="props.title" :width="700" draggable="">
			<el-form :model="ruleForm" ref="ruleFormRef" size="default" label-width="100px" :rules="rules">
				<el-row :gutter="35">
					<el-form-item v-show="false">
						<el-input v-model="ruleForm.id" />
					</el-form-item>
					<el-col :xs="24" :sm="12" :md="12" :lg="12" :xl="12" class="mb20">
						<el-form-item label="产品编码" prop="partNo">
							<el-input v-model="ruleForm.partNo" placeholder="请输入产品编码" clearable />
							
						</el-form-item>
						
					</el-col>
					<el-col :xs="24" :sm="12" :md="12" :lg="12" :xl="12" class="mb20">
						<el-form-item label="Batch" prop="batch">
							<el-input v-model="ruleForm.batch" placeholder="请输入Batch" clearable />
							
						</el-form-item>
						
					</el-col>
					<el-col :xs="24" :sm="12" :md="12" :lg="12" :xl="12" class="mb20">
						<el-form-item label="可用库存" prop="availableStock">
							<el-input v-model="ruleForm.availableStock" placeholder="请输入可用库存" clearable />
							
						</el-form-item>
						
					</el-col>
					<el-col :xs="24" :sm="12" :md="12" :lg="12" :xl="12" class="mb20">
						<el-form-item label="当前库存" prop="currentStock">
							<el-input v-model="ruleForm.currentStock" placeholder="请输入当前库存" clearable />
							
						</el-form-item>
						
					</el-col>
					<el-col :xs="24" :sm="12" :md="12" :lg="12" :xl="12" class="mb20">
						<el-form-item label="位置" prop="location">
							<el-input v-model="ruleForm.location" placeholder="请输入位置" clearable />
							
						</el-form-item>
						
					</el-col>
					<el-col :xs="24" :sm="12" :md="12" :lg="12" :xl="12" class="mb20">
						<el-form-item label="容器Bin" prop="bin">
							<el-input v-model="ruleForm.bin" placeholder="请输入容器Bin" clearable />
							
						</el-form-item>
						
					</el-col>
					<el-col :xs="24" :sm="12" :md="12" :lg="12" :xl="12" class="mb20">
						<el-form-item label="已弃用Serial" prop="serial">
							<el-input v-model="ruleForm.serial" placeholder="请输入已弃用Serial" clearable />
							
						</el-form-item>
						
					</el-col>
					<el-col :xs="24" :sm="12" :md="12" :lg="12" :xl="12" class="mb20">
						<el-form-item label="已弃用Serial" prop="aTPQty">
							<el-input v-model="ruleForm.aTPQty" placeholder="请输入已弃用Serial" clearable />
							
						</el-form-item>
						
					</el-col>
					<el-col :xs="24" :sm="12" :md="12" :lg="12" :xl="12" class="mb20">
						<el-form-item label="可使用量" prop="availableQOH">
							<el-input v-model="ruleForm.availableQOH" placeholder="请输入可使用量" clearable />
							
						</el-form-item>
						
					</el-col>
					<el-col :xs="24" :sm="12" :md="12" :lg="12" :xl="12" class="mb20">
						<el-form-item label="是否是原材料" prop="isRawMaterial">
							<el-input-number v-model="ruleForm.isRawMaterial" placeholder="请输入是否是原材料" clearable />
							
						</el-form-item>
						
					</el-col>
					<el-col :xs="24" :sm="12" :md="12" :lg="12" :xl="12" class="mb20">
						<el-form-item label="最小批量" prop="lotSize">
							<el-input-number v-model="ruleForm.lotSize" placeholder="请输入最小批量" clearable />
							
						</el-form-item>
						
					</el-col>
				</el-row>
			</el-form>
			<template #footer>
				<span class="dialog-footer">
					<el-button @click="cancel" size="default">取 消</el-button>
					<el-button type="primary" @click="submit" size="default">确 定</el-button>
				</span>
			</template>
		</el-dialog>
	</div>
</template>

<script lang="ts" setup>
	import { ref,onMounted } from "vue";
	import { ElMessage } from "element-plus";
	import type { FormRules } from "element-plus";
  	import { getAPI } from '/@/utils/axios-utils';
  	import { BDStockApi } from '/@/api-services/api';
	//父级传递来的参数
	var props = defineProps({
	title: {
	type: String,
	default: "",
	},
	});
	//父级传递来的函数，用于回调
	const emit = defineEmits(["reloadTable"]);
	const ruleFormRef = ref();
	const isShowDialog = ref(false);
	const ruleForm = ref<any>({});
		//自行删除非必填规则
		const rules = ref<FormRules>({
  id: [{required: true, message: '请输入Id！', trigger: 'blur',},],
  stockId: [{required: true, message: '请输入库存唯一标识！', trigger: 'blur',},],
  partID: [{required: true, message: '请输入产品Id，管理产品表！', trigger: 'blur',},],
  partNo: [{required: true, message: '请输入产品编码！', trigger: 'blur',},],
  partDesc: [{required: true, message: '请输入产品描述！', trigger: 'blur',},],
  orgID: [{required: true, message: '请输入组织ID！', trigger: 'blur',},],
  batch: [{required: true, message: '请输入Batch！', trigger: 'blur',},],
  maxStock: [{required: true, message: '请输入最大库存！', trigger: 'blur',},],
  minStock: [{required: true, message: '请输入最小库存！', trigger: 'blur',},],
  prodMode: [{required: true, message: '请输入已弃用ProdMode！', trigger: 'blur',},],
  availableStock: [{required: true, message: '请输入可用库存！', trigger: 'blur',},],
  currentStock: [{required: true, message: '请输入当前库存！', trigger: 'blur',},],
  errorRate: [{required: true, message: '请输入已弃用ErrorRate！', trigger: 'blur',},],
  sourceType: [{required: true, message: '请输入已弃用ErrorRate！', trigger: 'blur',},],
  promiseDate: [{required: true, message: '请输入已弃用ErrorRate！', trigger: 'blur',},],
  subInventoryCode: [{required: true, message: '请输入已弃用SubInventoryCode！', trigger: 'blur',},],
  locator: [{required: true, message: '请输入定位！', trigger: 'blur',},],
  location: [{required: true, message: '请输入位置！', trigger: 'blur',},],
  subLocation: [{required: true, message: '请输入转租(第三方)！', trigger: 'blur',},],
  bin: [{required: true, message: '请输入容器Bin！', trigger: 'blur',},],
  lot: [{required: true, message: '请输入批量！', trigger: 'blur',},],
  serial: [{required: true, message: '请输入已弃用Serial！', trigger: 'blur',},],
  aTPQty: [{required: true, message: '请输入已弃用Serial！', trigger: 'blur',},],
  committedQty: [{required: true, message: '请输入承诺数量！', trigger: 'blur',},],
  allocatedQTY: [{required: true, message: '请输入可分配数量！', trigger: 'blur',},],
  availableQOH: [{required: true, message: '请输入可使用量！', trigger: 'blur',},],
  safetyStock: [{required: true, message: '请输入安全数量！', trigger: 'blur',},],
  leadTime: [{required: true, message: '请输入LeadTime！', trigger: 'blur',},],
  shortageQty: [{required: true, message: '请输入缺少量！', trigger: 'blur',},],
  inventoryCalculation: [{required: true, message: '请输入库存量！', trigger: 'blur',},],
  isRawMaterial: [{required: true, message: '请输入是否是原材料！', trigger: 'blur',},],
  lotSize: [{required: true, message: '请输入最小批量！', trigger: 'blur',},],
  scrap: [{required: true, message: '请输入废品量！', trigger: 'blur',},],
  deburring: [{required: true, message: '请输入去毛刺！', trigger: 'blur',},],
  minOp: [{required: true, message: '请输入最小工序！', trigger: 'blur',},],
  powderType: [{required: true, message: '请输入粉料特性！', trigger: 'blur',},],
  gPLotSize: [{required: true, message: '请输入GP最小批量！', trigger: 'blur',},],
});

// 打开弹窗
const openDialog = (row: any) => {
  ruleForm.value = JSON.parse(JSON.stringify(row));
  isShowDialog.value = true;
};

// 关闭弹窗
const closeDialog = () => {
  emit("reloadTable");
  isShowDialog.value = false;
};

// 取消
const cancel = () => {
  isShowDialog.value = false;
};

// 提交
const submit = async () => {
  ruleFormRef.value.validate(async (isValid: boolean, fields?: any) => {
    if (isValid) {
      let values = ruleForm.value;
      if (ruleForm.value.id != undefined && ruleForm.value.id > 0) {
        await getAPI(BDStockApi).apiBDStockUpdatePost(values);
      } else {
        await getAPI(BDStockApi).apiBDStockAddPost(values);
      }
      closeDialog();
    } else {
      ElMessage({
        message: `表单有${Object.keys(fields).length}处验证失败，请修改后再提交`,
        type: "error",
      });
    }
  });
};





// 页面加载时
onMounted(async () => {
});

//将属性或者函数暴露给父组件
defineExpose({ openDialog });
</script>




