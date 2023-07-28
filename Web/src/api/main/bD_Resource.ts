import request from '/@/utils/request';
enum Api {
  AddBD_Resource = '/api/bD_Resource/add',
  DeleteBD_Resource = '/api/bD_Resource/delete',
  UpdateBD_Resource = '/api/bD_Resource/update',
  PageBD_Resource = '/api/bD_Resource/page',
}

// 增加资源设备信息
export const addBD_Resource = (params?: any) =>
	request({
		url: Api.AddBD_Resource,
		method: 'post',
		data: params,
	});

// 删除资源设备信息
export const deleteBD_Resource = (params?: any) => 
	request({
			url: Api.DeleteBD_Resource,
			method: 'post',
			data: params,
		});

// 编辑资源设备信息
export const updateBD_Resource = (params?: any) => 
	request({
			url: Api.UpdateBD_Resource,
			method: 'post',
			data: params,
		});

// 分页查询资源设备信息
export const pageBD_Resource = (params?: any) => 
	request({
			url: Api.PageBD_Resource,
			method: 'post',
			data: params,
		});


