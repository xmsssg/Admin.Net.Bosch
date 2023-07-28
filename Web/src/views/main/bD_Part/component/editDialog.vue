<template>
	<div class="bD_Part-container">
		<el-dialog v-model="isShowDialog" :title="props.title" :width="700" draggable="">
			<el-form :model="ruleForm" ref="ruleFormRef" size="default" label-width="100px" :rules="rules">
				<el-row :gutter="35">
					<el-form-item v-show="false">
						<el-input v-model="ruleForm.id" />
					</el-form-item>
					<el-col :xs="24" :sm="12" :md="12" :lg="12" :xl="12" class="mb20">
						<el-form-item label="产品编号" prop="partNo">
							<el-input v-model="ruleForm.partNo" placeholder="请输入产品编号" clearable />
							
						</el-form-item>
						
					</el-col>
					<el-col :xs="24" :sm="12" :md="12" :lg="12" :xl="12" class="mb20">
						<el-form-item label="产品描述" prop="partDesc">
							<el-input v-model="ruleForm.partDesc" placeholder="请输入产品描述" clearable />
							
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
  	import { BDPartApi } from '/@/api-services/api';
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
  partID: [{required: true, message: '请输入产品Id！', trigger: 'blur',},],
  orgID: [{required: true, message: '请输入组织Id！', trigger: 'blur',},],
  partNo: [{required: true, message: '请输入产品编号！', trigger: 'blur',},],
  partName: [{required: true, message: '请输入产品名称！', trigger: 'blur',},],
  partDesc: [{required: true, message: '请输入产品描述！', trigger: 'blur',},],
  partType: [{required: true, message: '请输入产品类型！', trigger: 'blur',},],
  productType: [{required: true, message: '请输入产品类型2！', trigger: 'blur',},],
  unitId: [{required: true, message: '请输入已弃用UnitId！', trigger: 'blur',},],
  attachName: [{required: true, message: '请输入已弃用AttachName！', trigger: 'blur',},],
  urlPath: [{required: true, message: '请输入已弃用UrlPath！', trigger: 'blur',},],
  attachment: [{required: true, message: '请输入已弃用产品图片链接！', trigger: 'blur',},],
  defaultMBDecision: [{required: true, message: '请输入已弃用DefaultMBDecision！', trigger: 'blur',},],
  mfgGroup: [{required: true, message: '请输入产品分组！', trigger: 'blur',},],
  fullLeadTime: [{required: true, message: '请输入已弃用LeadTime！', trigger: 'blur',},],
  plannerCode: [{required: true, message: '请输入计划编码！', trigger: 'blur',},],
  drawingNo: [{required: true, message: '请输入图纸编号！', trigger: 'blur',},],
  supplyType: [{required: true, message: '请输入供货类型！', trigger: 'blur',},],
  lotSize: [{required: true, message: '请输入最小批量！', trigger: 'blur',},],
  setupTimeST: [{required: true, message: '请输入准备时间ST！', trigger: 'blur',},],
  resPriority: [{required: true, message: '请输入优先级！', trigger: 'blur',},],
  groupNo: [{required: true, message: '请输入产品分组编码！', trigger: 'blur',},],
  familyNo: [{required: true, message: '请输入产品所属分类！', trigger: 'blur',},],
  categoryNo: [{required: true, message: '请输入类别！', trigger: 'blur',},],
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
        await getAPI(BDPartApi).apiBDPartUpdatePost(values);
      } else {
        await getAPI(BDPartApi).apiBDPartAddPost(values);
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




