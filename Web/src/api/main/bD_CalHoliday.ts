import request from '/@/utils/request';
enum Api {
  AddBD_CalHoliday = '/api/bD_CalHoliday/add',
  DeleteBD_CalHoliday = '/api/bD_CalHoliday/delete',
  UpdateBD_CalHoliday = '/api/bD_CalHoliday/update',
  PageBD_CalHoliday = '/api/bD_CalHoliday/page',
}

// 增加假期信息
export const addBD_CalHoliday = (params?: any) =>
	request({
		url: Api.AddBD_CalHoliday,
		method: 'post',
		data: params,
	});

// 删除假期信息
export const deleteBD_CalHoliday = (params?: any) => 
	request({
			url: Api.DeleteBD_CalHoliday,
			method: 'post',
			data: params,
		});

// 编辑假期信息
export const updateBD_CalHoliday = (params?: any) => 
	request({
			url: Api.UpdateBD_CalHoliday,
			method: 'post',
			data: params,
		});

// 分页查询假期信息
export const pageBD_CalHoliday = (params?: any) => 
	request({
			url: Api.PageBD_CalHoliday,
			method: 'post',
			data: params,
		});


