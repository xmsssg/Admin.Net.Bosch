import request from '/@/utils/request';
enum Api {
  AddBD_ChangeMatrix = '/api/bD_ChangeMatrix/add',
  DeleteBD_ChangeMatrix = '/api/bD_ChangeMatrix/delete',
  UpdateBD_ChangeMatrix = '/api/bD_ChangeMatrix/update',
  PageBD_ChangeMatrix = '/api/bD_ChangeMatrix/page',
}

// 增加换型矩阵
export const addBD_ChangeMatrix = (params?: any) =>
	request({
		url: Api.AddBD_ChangeMatrix,
		method: 'post',
		data: params,
	});

// 删除换型矩阵
export const deleteBD_ChangeMatrix = (params?: any) => 
	request({
			url: Api.DeleteBD_ChangeMatrix,
			method: 'post',
			data: params,
		});

// 编辑换型矩阵
export const updateBD_ChangeMatrix = (params?: any) => 
	request({
			url: Api.UpdateBD_ChangeMatrix,
			method: 'post',
			data: params,
		});

// 分页查询换型矩阵
export const pageBD_ChangeMatrix = (params?: any) => 
	request({
			url: Api.PageBD_ChangeMatrix,
			method: 'post',
			data: params,
		});


