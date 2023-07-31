<template>
	<div class="bD_MachineThird-container">
		<el-dialog v-model="isShowDialog" :title="props.title" :width="700" draggable="">
			<el-form :model="ruleForm" ref="ruleFormRef" size="default" label-width="100px" :rules="rules">
				<el-row :gutter="35">
					<el-form-item v-show="false">
						<el-input v-model="ruleForm.id" />
					</el-form-item>
					<el-col :xs="24" :sm="12" :md="12" :lg="12" :xl="12" class="mb20">
						<el-form-item label="分组编码" prop="groupNo">
							<el-input v-model="ruleForm.groupNo" placeholder="请输入分组编码" clearable />
							
						</el-form-item>
						
					</el-col>
					<el-col :xs="24" :sm="12" :md="12" :lg="12" :xl="12" class="mb20">
						<el-form-item label="设备编码" prop="resNo">
							<el-input v-model="ruleForm.resNo" placeholder="请输入设备编码" clearable />
							
						</el-form-item>
						
					</el-col>
					<el-col :xs="24" :sm="12" :md="12" :lg="12" :xl="12" class="mb20">
						<el-form-item label="压机属性(单料/双料)" prop="maetype">
							<el-input-number v-model="ruleForm.maetype" placeholder="请输入压机属性(单料/双料)" clearable />
							
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
  	import { BDMachineThirdApi } from '/@/api-services/api';
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
  groupNo: [{required: true, message: '请输入分组编码！', trigger: 'blur',},],
  groupDesc: [{required: true, message: '请输入分组描述！', trigger: 'blur',},],
  resNo: [{required: true, message: '请输入设备编码！', trigger: 'blur',},],
  orgId: [{required: true, message: '请输入OrgId！', trigger: 'blur',},],
  machineType: [{required: true, message: '请输入分组类型！', trigger: 'blur',},],
  maetype: [{required: true, message: '请输入压机属性(单料/双料)！', trigger: 'blur',},],
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
        await getAPI(BDMachineThirdApi).apiBDMachineThirdUpdatePost(values);
      } else {
        await getAPI(BDMachineThirdApi).apiBDMachineThirdAddPost(values);
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




