import request from '/@/utils/request';
enum Api {
  AddBD_Part = '/api/bD_Part/add',
  DeleteBD_Part = '/api/bD_Part/delete',
  UpdateBD_Part = '/api/bD_Part/update',
  PageBD_Part = '/api/bD_Part/page',
}

// 增加产品信息
export const addBD_Part = (params?: any) =>
	request({
		url: Api.AddBD_Part,
		method: 'post',
		data: params,
	});

// 删除产品信息
export const deleteBD_Part = (params?: any) => 
	request({
			url: Api.DeleteBD_Part,
			method: 'post',
			data: params,
		});

// 编辑产品信息
export const updateBD_Part = (params?: any) => 
	request({
			url: Api.UpdateBD_Part,
			method: 'post',
			data: params,
		});

// 分页查询产品信息
export const pageBD_Part = (params?: any) => 
	request({
			url: Api.PageBD_Part,
			method: 'post',
			data: params,
		});


