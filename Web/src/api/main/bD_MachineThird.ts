import request from '/@/utils/request';
enum Api {
  AddBD_MachineThird = '/api/bD_MachineThird/add',
  DeleteBD_MachineThird = '/api/bD_MachineThird/delete',
  UpdateBD_MachineThird = '/api/bD_MachineThird/update',
  PageBD_MachineThird = '/api/bD_MachineThird/page',
}

// 增加人机比1v3
export const addBD_MachineThird = (params?: any) =>
	request({
		url: Api.AddBD_MachineThird,
		method: 'post',
		data: params,
	});

// 删除人机比1v3
export const deleteBD_MachineThird = (params?: any) => 
	request({
			url: Api.DeleteBD_MachineThird,
			method: 'post',
			data: params,
		});

// 编辑人机比1v3
export const updateBD_MachineThird = (params?: any) => 
	request({
			url: Api.UpdateBD_MachineThird,
			method: 'post',
			data: params,
		});

// 分页查询人机比1v3
export const pageBD_MachineThird = (params?: any) => 
	request({
			url: Api.PageBD_MachineThird,
			method: 'post',
			data: params,
		});


