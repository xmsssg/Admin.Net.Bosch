<template>
	<div class="bD_Resource-container">
		<el-dialog v-model="isShowDialog" :title="props.title" :width="700" draggable="">
			<el-form :model="ruleForm" ref="ruleFormRef" size="default" label-width="100px" :rules="rules">
				<el-row :gutter="35">
					<el-form-item v-show="false">
						<el-input v-model="ruleForm.id" />
					</el-form-item>
					<el-col :xs="24" :sm="12" :md="12" :lg="12" :xl="12" class="mb20">
						<el-form-item label="设备名称" prop="resName">
							<el-input v-model="ruleForm.resName" placeholder="请输入设备名称" clearable />
							
						</el-form-item>
						
					</el-col>
					<el-col :xs="24" :sm="12" :md="12" :lg="12" :xl="12" class="mb20">
						<el-form-item label="设备描述" prop="resDesc">
							<el-input v-model="ruleForm.resDesc" placeholder="请输入设备描述" clearable />
							
						</el-form-item>
						
					</el-col>
					<el-col :xs="24" :sm="12" :md="12" :lg="12" :xl="12" class="mb20">
						<el-form-item label="设备类型" prop="type">
							<el-input-number v-model="ruleForm.type" placeholder="请输入设备类型" clearable />
							
						</el-form-item>
						
					</el-col>
					<el-col :xs="24" :sm="12" :md="12" :lg="12" :xl="12" class="mb20">
						<el-form-item label="设备产能类型" prop="resType">
							<el-input-number v-model="ruleForm.resType" placeholder="请输入设备产能类型" clearable />
							
						</el-form-item>
						
					</el-col>
					<el-col :xs="24" :sm="12" :md="12" :lg="12" :xl="12" class="mb20">
						<el-form-item label="工作中心编号" prop="workCenterNo">
							<el-input v-model="ruleForm.workCenterNo" placeholder="请输入工作中心编号" clearable />
							
						</el-form-item>
						
					</el-col>
					<el-col :xs="24" :sm="12" :md="12" :lg="12" :xl="12" class="mb20">
						<el-form-item label="设备数量" prop="units">
							<el-input-number v-model="ruleForm.units" placeholder="请输入设备数量" clearable />
							
						</el-form-item>
						
					</el-col>
					<el-col :xs="24" :sm="12" :md="12" :lg="12" :xl="12" class="mb20">
						<el-form-item label="设备是否可用" prop="isAvailable">
							<el-input-number v-model="ruleForm.isAvailable" placeholder="请输入设备是否可用" clearable />
							
						</el-form-item>
						
					</el-col>
					<el-col :xs="24" :sm="12" :md="12" :lg="12" :xl="12" class="mb20">
						<el-form-item label="设备编码" prop="resNo">
							<el-input v-model="ruleForm.resNo" placeholder="请输入设备编码" clearable />
							
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
	import { BDResourceApi } from '/@/api-services/api';
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
  resID: [{required: true, message: '请输入Id，唯一标识！', trigger: 'blur',},],
  depID: [{required: true, message: '请输入部门Id，关联部门表！', trigger: 'blur',},],
  resName: [{required: true, message: '请输入设备名称！', trigger: 'blur',},],
  resDesc: [{required: true, message: '请输入设备描述！', trigger: 'blur',},],
  status: [{required: true, message: '请输入已弃用Status！', trigger: 'blur',},],
  type: [{required: true, message: '请输入设备类型！', trigger: 'blur',},],
  resType: [{required: true, message: '请输入设备产能类型！', trigger: 'blur',},],
  workCenterNo: [{required: true, message: '请输入工作中心编号！', trigger: 'blur',},],
  units: [{required: true, message: '请输入设备数量！', trigger: 'blur',},],
  programmable: [{required: true, message: '请输入已弃用Programmable！', trigger: 'blur',},],
  isSeparable: [{required: true, message: '请输入已弃用IsSeparable！', trigger: 'blur',},],
  isAvailable: [{required: true, message: '请输入设备是否可用！', trigger: 'blur',},],
  isHeattreat: [{required: true, message: '请输入是否是热处理设备！', trigger: 'blur',},],
  overtime: [{required: true, message: '请输入Overtime已弃用！', trigger: 'blur',},],
  orgID: [{required: true, message: '请输入组织编码！', trigger: 'blur',},],
  processTime: [{required: true, message: '请输入加工时间！', trigger: 'blur',},],
  setuptime1: [{required: true, message: '请输入准备时间1！', trigger: 'blur',},],
  setuptime2: [{required: true, message: '请输入准备时间2！', trigger: 'blur',},],
  setuptime3: [{required: true, message: '请输入准备时间3！', trigger: 'blur',},],
  versionSign: [{required: true, message: '请输入共用编码！', trigger: 'blur',},],
  isOld: [{required: true, message: '请输入isOld已弃用！', trigger: 'blur',},],
  resNo: [{required: true, message: '请输入设备编码！', trigger: 'blur',},],
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
        await getAPI(BDResourceApi).apiBDResourceUpdatePost(values);
      } else {
        await getAPI(BDResourceApi).apiBDResourceAddPost(values);
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




