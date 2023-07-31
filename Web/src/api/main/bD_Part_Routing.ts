import request from '/@/utils/request';
enum Api {
  AddBD_Part_Routing = '/api/bD_Part_Routing/add',
  DeleteBD_Part_Routing = '/api/bD_Part_Routing/delete',
  UpdateBD_Part_Routing = '/api/bD_Part_Routing/update',
  PageBD_Part_Routing = '/api/bD_Part_Routing/page',
}

// 增加调度Routing信息
export const addBD_Part_Routing = (params?: any) =>
	request({
		url: Api.AddBD_Part_Routing,
		method: 'post',
		data: params,
	});

// 删除调度Routing信息
export const deleteBD_Part_Routing = (params?: any) => 
	request({
			url: Api.DeleteBD_Part_Routing,
			method: 'post',
			data: params,
		});

// 编辑调度Routing信息
export const updateBD_Part_Routing = (params?: any) => 
	request({
			url: Api.UpdateBD_Part_Routing,
			method: 'post',
			data: params,
		});

// 分页查询调度Routing信息
export const pageBD_Part_Routing = (params?: any) => 
	request({
			url: Api.PageBD_Part_Routing,
			method: 'post',
			data: params,
		});


