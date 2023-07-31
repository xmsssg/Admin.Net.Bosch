import request from '/@/utils/request';
enum Api {
  AddBD_BOM = '/api/bD_BOM/add',
  DeleteBD_BOM = '/api/bD_BOM/delete',
  UpdateBD_BOM = '/api/bD_BOM/update',
  PageBD_BOM = '/api/bD_BOM/page',
}

// 增加BOM信息
export const addBD_BOM = (params?: any) =>
	request({
		url: Api.AddBD_BOM,
		method: 'post',
		data: params,
	});

// 删除BOM信息
export const deleteBD_BOM = (params?: any) => 
	request({
			url: Api.DeleteBD_BOM,
			method: 'post',
			data: params,
		});

// 编辑BOM信息
export const updateBD_BOM = (params?: any) => 
	request({
			url: Api.UpdateBD_BOM,
			method: 'post',
			data: params,
		});

// 分页查询BOM信息
export const pageBD_BOM = (params?: any) => 
	request({
			url: Api.PageBD_BOM,
			method: 'post',
			data: params,
		});


