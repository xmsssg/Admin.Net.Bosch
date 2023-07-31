import request from '/@/utils/request';
enum Api {
  AddBD_Stock = '/api/bD_Stock/add',
  DeleteBD_Stock = '/api/bD_Stock/delete',
  UpdateBD_Stock = '/api/bD_Stock/update',
  PageBD_Stock = '/api/bD_Stock/page',
}

// 增加库存信息
export const addBD_Stock = (params?: any) =>
	request({
		url: Api.AddBD_Stock,
		method: 'post',
		data: params,
	});

// 删除库存信息
export const deleteBD_Stock = (params?: any) => 
	request({
			url: Api.DeleteBD_Stock,
			method: 'post',
			data: params,
		});

// 编辑库存信息
export const updateBD_Stock = (params?: any) => 
	request({
			url: Api.UpdateBD_Stock,
			method: 'post',
			data: params,
		});

// 分页查询库存信息
export const pageBD_Stock = (params?: any) => 
	request({
			url: Api.PageBD_Stock,
			method: 'post',
			data: params,
		});


