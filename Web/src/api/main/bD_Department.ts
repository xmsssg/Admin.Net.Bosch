import request from '/@/utils/request';
enum Api {
  AddBD_Department = '/api/bD_Department/add',
  DeleteBD_Department = '/api/bD_Department/delete',
  UpdateBD_Department = '/api/bD_Department/update',
  PageBD_Department = '/api/bD_Department/page',
}

// 增加部门信息
export const addBD_Department = (params?: any) =>
	request({
		url: Api.AddBD_Department,
		method: 'post',
		data: params,
	});

// 删除部门信息
export const deleteBD_Department = (params?: any) => 
	request({
			url: Api.DeleteBD_Department,
			method: 'post',
			data: params,
		});

// 编辑部门信息
export const updateBD_Department = (params?: any) => 
	request({
			url: Api.UpdateBD_Department,
			method: 'post',
			data: params,
		});

// 分页查询部门信息
export const pageBD_Department = (params?: any) => 
	request({
			url: Api.PageBD_Department,
			method: 'post',
			data: params,
		});


