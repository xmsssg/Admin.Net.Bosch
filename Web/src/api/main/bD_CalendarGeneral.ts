import request from '/@/utils/request';
enum Api {
  AddBD_CalendarGeneral = '/api/bD_CalendarGeneral/add',
  DeleteBD_CalendarGeneral = '/api/bD_CalendarGeneral/delete',
  UpdateBD_CalendarGeneral = '/api/bD_CalendarGeneral/update',
  PageBD_CalendarGeneral = '/api/bD_CalendarGeneral/page',
}

// 增加日历信息
export const addBD_CalendarGeneral = (params?: any) =>
	request({
		url: Api.AddBD_CalendarGeneral,
		method: 'post',
		data: params,
	});

// 删除日历信息
export const deleteBD_CalendarGeneral = (params?: any) => 
	request({
			url: Api.DeleteBD_CalendarGeneral,
			method: 'post',
			data: params,
		});

// 编辑日历信息
export const updateBD_CalendarGeneral = (params?: any) => 
	request({
			url: Api.UpdateBD_CalendarGeneral,
			method: 'post',
			data: params,
		});

// 分页查询日历信息
export const pageBD_CalendarGeneral = (params?: any) => 
	request({
			url: Api.PageBD_CalendarGeneral,
			method: 'post',
			data: params,
		});


