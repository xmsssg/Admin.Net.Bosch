<template>
	<div class="bD_Department-container">
		<el-dialog v-model="isShowDialog" :title="props.title" :width="700" draggable="">
			<el-form :model="ruleForm" ref="ruleFormRef" size="default" label-width="100px" :rules="rules">
				<el-row :gutter="35">
					<el-form-item v-show="false">
						<el-input v-model="ruleForm.id" />
					</el-form-item>
					<el-col :xs="24" :sm="12" :md="12" :lg="12" :xl="12" class="mb20">
						<el-form-item label="部门Id，唯一标识" prop="depId">
							<el-input v-model="ruleForm.depId" placeholder="请输入部门Id，唯一标识" clearable />
							
						</el-form-item>
						
					</el-col>
					<el-col :xs="24" :sm="12" :md="12" :lg="12" :xl="12" class="mb20">
						<el-form-item label="部门WorkshopId" prop="workshopId">
							<el-input v-model="ruleForm.workshopId" placeholder="请输入部门WorkshopId" clearable />
							
						</el-form-item>
						
					</el-col>
					<el-col :xs="24" :sm="12" :md="12" :lg="12" :xl="12" class="mb20">
						<el-form-item label="部门编号" prop="depNo">
							<el-input v-model="ruleForm.depNo" placeholder="请输入部门编号" clearable />
							
						</el-form-item>
						
					</el-col>
					<el-col :xs="24" :sm="12" :md="12" :lg="12" :xl="12" class="mb20">
						<el-form-item label="部门名称" prop="depName">
							<el-input v-model="ruleForm.depName" placeholder="请输入部门名称" clearable />
							
						</el-form-item>
						
					</el-col>
					<el-col :xs="24" :sm="12" :md="12" :lg="12" :xl="12" class="mb20">
						<el-form-item label="部门描述" prop="depDesc">
							<el-input v-model="ruleForm.depDesc" placeholder="请输入部门描述" clearable />
							
						</el-form-item>
						
					</el-col>
					<el-col :xs="24" :sm="12" :md="12" :lg="12" :xl="12" class="mb20">
						<el-form-item label="部门状态，默认为1" prop="status">
							<el-input-number v-model="ruleForm.status" placeholder="请输入部门状态，默认为1" clearable />
							
						</el-form-item>
						
					</el-col>
					<el-col :xs="24" :sm="12" :md="12" :lg="12" :xl="12" class="mb20">
						<el-form-item label="部门备注，现用于部门类型" prop="remarks">
							<el-input v-model="ruleForm.remarks" placeholder="请输入部门备注，现用于部门类型" clearable />
							
						</el-form-item>
						
					</el-col>
					<el-col :xs="24" :sm="12" :md="12" :lg="12" :xl="12" class="mb20">
						<el-form-item label="组织OrgId" prop="orgID">
							<el-input v-model="ruleForm.orgID" placeholder="请输入组织OrgId" clearable />
							
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
	import { addBD_Department, updateBD_Department } from "/@/api/main/bD_Department";
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
  depId: [{required: true, message: '请输入部门Id，唯一标识！', trigger: 'blur',},],
  workshopId: [{required: true, message: '请输入部门WorkshopId！', trigger: 'blur',},],
  depNo: [{required: true, message: '请输入部门编号！', trigger: 'blur',},],
  depName: [{required: true, message: '请输入部门名称！', trigger: 'blur',},],
  depDesc: [{required: true, message: '请输入部门描述！', trigger: 'blur',},],
  status: [{required: true, message: '请输入部门状态，默认为1！', trigger: 'blur',},],
  remarks: [{required: true, message: '请输入部门备注，现用于部门类型！', trigger: 'blur',},],
  orgID: [{required: true, message: '请输入组织OrgId！', trigger: 'blur',},],
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
        await updateBD_Department(values);
      } else {
        await addBD_Department(values);
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




