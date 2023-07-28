<template>
	<div class="bD_BOM-container">
		<el-dialog v-model="isShowDialog" :title="props.title" :width="700" draggable="">
			<el-form :model="ruleForm" ref="ruleFormRef" size="default" label-width="100px" :rules="rules">
				<el-row :gutter="35">
					<el-form-item v-show="false">
						<el-input v-model="ruleForm.id" />
					</el-form-item>
					<el-col :xs="24" :sm="12" :md="12" :lg="12" :xl="12" class="mb20">
						<el-form-item label="主产品Id" prop="masterPartId">
							<el-input v-model="ruleForm.masterPartId" placeholder="请输入主产品Id" clearable />
							
						</el-form-item>
						
					</el-col>
					<el-col :xs="24" :sm="12" :md="12" :lg="12" :xl="12" class="mb20">
						<el-form-item label="主产品Id" prop="subPartId">
							<el-input v-model="ruleForm.subPartId" placeholder="请输入主产品Id" clearable />
							
						</el-form-item>
						
					</el-col>
					<el-col :xs="24" :sm="12" :md="12" :lg="12" :xl="12" class="mb20">
						<el-form-item label="根产成品Id" prop="rootPartId">
							<el-input v-model="ruleForm.rootPartId" placeholder="请输入根产成品Id" clearable />
							
						</el-form-item>
						
					</el-col>
					<el-col :xs="24" :sm="12" :md="12" :lg="12" :xl="12" class="mb20">
						<el-form-item label="比例" prop="needQty">
							<el-input v-model="ruleForm.needQty" placeholder="请输入比例" clearable />
							
						</el-form-item>
						
					</el-col>
					<el-col :xs="24" :sm="12" :md="12" :lg="12" :xl="12" class="mb20">
						<el-form-item label="层级" prop="level">
							<el-input-number v-model="ruleForm.level" placeholder="请输入层级" clearable />
							
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
import { BDBOMApi } from '/@/api-services/api';
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
  bomId: [{required: true, message: '请输入BOMId！', trigger: 'blur',},],
  orgId: [{required: true, message: '请输入组织Id！', trigger: 'blur',},],
  masterPartId: [{required: true, message: '请输入主产品Id！', trigger: 'blur',},],
  subPartId: [{required: true, message: '请输入主产品Id！', trigger: 'blur',},],
  rootPartId: [{required: true, message: '请输入根产成品Id！', trigger: 'blur',},],
  needQty: [{required: true, message: '请输入比例！', trigger: 'blur',},],
  subProductType: [{required: true, message: '请输入子产品类型！', trigger: 'blur',},],
  level: [{required: true, message: '请输入层级！', trigger: 'blur',},],
  bomPath: [{required: true, message: '请输入图纸链接！', trigger: 'blur',},],
  opNo: [{required: true, message: '请输入对应工序！', trigger: 'blur',},],
  upperLayerBomid: [{required: true, message: '请输入上层BOM Id！', trigger: 'blur',},],
  partBomId: [{required: true, message: '请输入PartBomId！', trigger: 'blur',},],
  slevel: [{required: true, message: '请输入子产品层级！', trigger: 'blur',},],
  mlevel: [{required: true, message: '请输入主产品层级！', trigger: 'blur',},],
  masterPartType: [{required: true, message: '请输入主产品类型！', trigger: 'blur',},],
  subPartType: [{required: true, message: '请输入子产品类型！', trigger: 'blur',},],
  startTime: [{required: true, message: '请选择子产品类型！', trigger: 'change',},],
  stopTime: [{required: true, message: '请选择子产品类型！', trigger: 'change',},],
  availableLine: [{required: true, message: '请输入子产品类型！', trigger: 'blur',},],
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
        await getAPI(BDBOMApi).apiBDBOMUpdatePost(values);
      } else {
		await getAPI(BDBOMApi).apiBDBOMAddPost(values);
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




