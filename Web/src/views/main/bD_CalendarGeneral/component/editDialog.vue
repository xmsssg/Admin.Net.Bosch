<template>
	<div class="bD_CalendarGeneral-container">
		<el-dialog v-model="isShowDialog" :title="props.title" :width="700" draggable="">
			<el-form :model="ruleForm" ref="ruleFormRef" size="default" label-width="100px" :rules="rules">
				<el-row :gutter="35">
					<el-form-item v-show="false">
						<el-input v-model="ruleForm.id" />
					</el-form-item>
					<el-col :xs="24" :sm="12" :md="12" :lg="12" :xl="12" class="mb20">
						<el-form-item label="日历编码" prop="calNo">
							<el-input v-model="ruleForm.calNo" placeholder="请输入日历编码" clearable />
							
						</el-form-item>
						
					</el-col>
					<el-col :xs="24" :sm="12" :md="12" :lg="12" :xl="12" class="mb20">
						<el-form-item label="日历名称" prop="calName">
							<el-input v-model="ruleForm.calName" placeholder="请输入日历名称" clearable />
							
						</el-form-item>
						
					</el-col>
					<el-col :xs="24" :sm="12" :md="12" :lg="12" :xl="12" class="mb20">
						<el-form-item label="可用开始时间" prop="beginDate">
							<el-date-picker v-model="ruleForm.beginDate" type="date" placeholder="可用开始时间" />
							
						</el-form-item>
						
					</el-col>
					<el-col :xs="24" :sm="12" :md="12" :lg="12" :xl="12" class="mb20">
						<el-form-item label="可用结束时间" prop="endDate">
							<el-date-picker v-model="ruleForm.endDate" type="date" placeholder="可用结束时间" />
							
						</el-form-item>
						
					</el-col>
					<el-col :xs="24" :sm="12" :md="12" :lg="12" :xl="12" class="mb20">
						<el-form-item label="工作日" prop="workDay">
							<el-input v-model="ruleForm.workDay" placeholder="请输入工作日" clearable />
							
						</el-form-item>
						
					</el-col>
					<el-col :xs="24" :sm="12" :md="12" :lg="12" :xl="12" class="mb20">
						<el-form-item label="班次1" prop="shift1">
							<el-input v-model="ruleForm.shift1" placeholder="请输入班次1" clearable />
							
						</el-form-item>
						
					</el-col>
					<el-col :xs="24" :sm="12" :md="12" :lg="12" :xl="12" class="mb20">
						<el-form-item label="班次2" prop="shift2">
							<el-input v-model="ruleForm.shift2" placeholder="请输入班次2" clearable />
							
						</el-form-item>
						
					</el-col>
					<el-col :xs="24" :sm="12" :md="12" :lg="12" :xl="12" class="mb20">
						<el-form-item label="班次3" prop="shift3">
							<el-input v-model="ruleForm.shift3" placeholder="请输入班次3" clearable />
							
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
  	import { BDCalendarGeneralApi } from '/@/api-services/api';
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
  guid: [{required: true, message: '请输入Guid！', trigger: 'blur',},],
  resId: [{required: true, message: '请输入ResId(弃用)！', trigger: 'blur',},],
  resNo: [{required: true, message: '请输入ResNo(弃用)！', trigger: 'blur',},],
  orgId: [{required: true, message: '请输入OrgId！', trigger: 'blur',},],
  calNo: [{required: true, message: '请输入日历编码！', trigger: 'blur',},],
  calName: [{required: true, message: '请输入日历名称！', trigger: 'blur',},],
  beginDate: [{required: true, message: '请选择可用开始时间！', trigger: 'change',},],
  endDate: [{required: true, message: '请选择可用结束时间！', trigger: 'change',},],
  remark: [{required: true, message: '请输入备注！', trigger: 'blur',},],
  workDay: [{required: true, message: '请输入工作日！', trigger: 'blur',},],
  shift1: [{required: true, message: '请输入班次1！', trigger: 'blur',},],
  shift2: [{required: true, message: '请输入班次2！', trigger: 'blur',},],
  shift3: [{required: true, message: '请输入班次3！', trigger: 'blur',},],
  type: [{required: true, message: '请输入日历类型！', trigger: 'blur',},],
  priority: [{required: true, message: '请输入优先级！', trigger: 'blur',},],
  isDefault: [{required: true, message: '请输入是否默认！', trigger: 'blur',},],
  workCenterNo: [{required: true, message: '请输入工作中心编码！', trigger: 'blur',},],
  calId: [{required: true, message: '请输入管理日历信息表Id！', trigger: 'blur',},],
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
        await getAPI(BDCalendarGeneralApi).apiBDCalendarGeneralUpdatePost(values);
      } else {
        await getAPI(BDCalendarGeneralApi).apiBDCalendarGeneralAddPost(values);
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




