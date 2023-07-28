/* tslint:disable */
/* eslint-disable */
/**
 * 业务应用
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.0.0
 * 
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */
import globalAxios, { AxiosResponse, AxiosInstance, AxiosRequestConfig } from 'axios';
import { Configuration } from '../configuration';
// Some imports not used depending on template conditions
// @ts-ignore
import { BASE_PATH, COLLECTION_FORMATS, RequestArgs, BaseAPI, RequiredError } from '../base';
import { AddBDStockInput } from '../models';
import { AdminResultBDStock } from '../models';
import { AdminResultListBDStockOutput } from '../models';
import { AdminResultSqlSugarPagedListBDStockOutput } from '../models';
import { BDStockInput } from '../models';
import { DeleteBDStockInput } from '../models';
import { UpdateBDStockInput } from '../models';
/**
 * BDStockApi - axios parameter creator
 * @export
 */
export const BDStockApiAxiosParamCreator = function (configuration?: Configuration) {
    return {
        /**
         * 
         * @param {AddBDStockInput} [body] 
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        apiBDStockAddPost: async (body?: AddBDStockInput, options: AxiosRequestConfig = {}): Promise<RequestArgs> => {
            const localVarPath = `/api/bD_Stock/add`;
            // use dummy base URL string because the URL constructor only accepts absolute URLs.
            const localVarUrlObj = new URL(localVarPath, 'https://example.com');
            let baseOptions;
            if (configuration) {
                baseOptions = configuration.baseOptions;
            }
            const localVarRequestOptions :AxiosRequestConfig = { method: 'POST', ...baseOptions, ...options};
            const localVarHeaderParameter = {} as any;
            const localVarQueryParameter = {} as any;

            // authentication Bearer required
            // http bearer authentication required
            if (configuration && configuration.accessToken) {
                const accessToken = typeof configuration.accessToken === 'function'
                    ? await configuration.accessToken()
                    : await configuration.accessToken;
                localVarHeaderParameter["Authorization"] = "Bearer " + accessToken;
            }

            localVarHeaderParameter['Content-Type'] = 'application/json-patch+json';

            const query = new URLSearchParams(localVarUrlObj.search);
            for (const key in localVarQueryParameter) {
                query.set(key, localVarQueryParameter[key]);
            }
            for (const key in options.params) {
                query.set(key, options.params[key]);
            }
            localVarUrlObj.search = (new URLSearchParams(query)).toString();
            let headersFromBaseOptions = baseOptions && baseOptions.headers ? baseOptions.headers : {};
            localVarRequestOptions.headers = {...localVarHeaderParameter, ...headersFromBaseOptions, ...options.headers};
            const needsSerialization = (typeof body !== "string") || localVarRequestOptions.headers['Content-Type'] === 'application/json';
            localVarRequestOptions.data =  needsSerialization ? JSON.stringify(body !== undefined ? body : {}) : (body || "");

            return {
                url: localVarUrlObj.pathname + localVarUrlObj.search + localVarUrlObj.hash,
                options: localVarRequestOptions,
            };
        },
        /**
         * 
         * @param {DeleteBDStockInput} [body] 
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        apiBDStockDeletePost: async (body?: DeleteBDStockInput, options: AxiosRequestConfig = {}): Promise<RequestArgs> => {
            const localVarPath = `/api/bD_Stock/delete`;
            // use dummy base URL string because the URL constructor only accepts absolute URLs.
            const localVarUrlObj = new URL(localVarPath, 'https://example.com');
            let baseOptions;
            if (configuration) {
                baseOptions = configuration.baseOptions;
            }
            const localVarRequestOptions :AxiosRequestConfig = { method: 'POST', ...baseOptions, ...options};
            const localVarHeaderParameter = {} as any;
            const localVarQueryParameter = {} as any;

            // authentication Bearer required
            // http bearer authentication required
            if (configuration && configuration.accessToken) {
                const accessToken = typeof configuration.accessToken === 'function'
                    ? await configuration.accessToken()
                    : await configuration.accessToken;
                localVarHeaderParameter["Authorization"] = "Bearer " + accessToken;
            }

            localVarHeaderParameter['Content-Type'] = 'application/json-patch+json';

            const query = new URLSearchParams(localVarUrlObj.search);
            for (const key in localVarQueryParameter) {
                query.set(key, localVarQueryParameter[key]);
            }
            for (const key in options.params) {
                query.set(key, options.params[key]);
            }
            localVarUrlObj.search = (new URLSearchParams(query)).toString();
            let headersFromBaseOptions = baseOptions && baseOptions.headers ? baseOptions.headers : {};
            localVarRequestOptions.headers = {...localVarHeaderParameter, ...headersFromBaseOptions, ...options.headers};
            const needsSerialization = (typeof body !== "string") || localVarRequestOptions.headers['Content-Type'] === 'application/json';
            localVarRequestOptions.data =  needsSerialization ? JSON.stringify(body !== undefined ? body : {}) : (body || "");

            return {
                url: localVarUrlObj.pathname + localVarUrlObj.search + localVarUrlObj.hash,
                options: localVarRequestOptions,
            };
        },
        /**
         * 
         * @param {number} id 主键Id
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        apiBDStockDetailGet: async (id: number, options: AxiosRequestConfig = {}): Promise<RequestArgs> => {
            // verify required parameter 'id' is not null or undefined
            if (id === null || id === undefined) {
                throw new RequiredError('id','Required parameter id was null or undefined when calling apiBDStockDetailGet.');
            }
            const localVarPath = `/api/bD_Stock/detail`;
            // use dummy base URL string because the URL constructor only accepts absolute URLs.
            const localVarUrlObj = new URL(localVarPath, 'https://example.com');
            let baseOptions;
            if (configuration) {
                baseOptions = configuration.baseOptions;
            }
            const localVarRequestOptions :AxiosRequestConfig = { method: 'GET', ...baseOptions, ...options};
            const localVarHeaderParameter = {} as any;
            const localVarQueryParameter = {} as any;

            // authentication Bearer required
            // http bearer authentication required
            if (configuration && configuration.accessToken) {
                const accessToken = typeof configuration.accessToken === 'function'
                    ? await configuration.accessToken()
                    : await configuration.accessToken;
                localVarHeaderParameter["Authorization"] = "Bearer " + accessToken;
            }

            if (id !== undefined) {
                localVarQueryParameter['Id'] = id;
            }

            const query = new URLSearchParams(localVarUrlObj.search);
            for (const key in localVarQueryParameter) {
                query.set(key, localVarQueryParameter[key]);
            }
            for (const key in options.params) {
                query.set(key, options.params[key]);
            }
            localVarUrlObj.search = (new URLSearchParams(query)).toString();
            let headersFromBaseOptions = baseOptions && baseOptions.headers ? baseOptions.headers : {};
            localVarRequestOptions.headers = {...localVarHeaderParameter, ...headersFromBaseOptions, ...options.headers};

            return {
                url: localVarUrlObj.pathname + localVarUrlObj.search + localVarUrlObj.hash,
                options: localVarRequestOptions,
            };
        },
        /**
         * 
         * @param {string} [partNo] 
         * @param {string} [batch] 
         * @param {number} [availableStock] 
         * @param {number} [currentStock] 
         * @param {string} [location] 
         * @param {string} [bin] 
         * @param {string} [serial] 
         * @param {number} [aTPQty] 
         * @param {number} [availableQOH] 
         * @param {number} [isRawMaterial] 
         * @param {number} [lotSize] 
         * @param {number} [page] 当前页码
         * @param {number} [pageSize] 页码容量
         * @param {string} [field] 排序字段
         * @param {string} [order] 排序方向
         * @param {string} [descStr] 降序排序
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        apiBDStockListGet: async (partNo?: string, batch?: string, availableStock?: number, currentStock?: number, location?: string, bin?: string, serial?: string, aTPQty?: number, availableQOH?: number, isRawMaterial?: number, lotSize?: number, page?: number, pageSize?: number, field?: string, order?: string, descStr?: string, options: AxiosRequestConfig = {}): Promise<RequestArgs> => {
            const localVarPath = `/api/bD_Stock/list`;
            // use dummy base URL string because the URL constructor only accepts absolute URLs.
            const localVarUrlObj = new URL(localVarPath, 'https://example.com');
            let baseOptions;
            if (configuration) {
                baseOptions = configuration.baseOptions;
            }
            const localVarRequestOptions :AxiosRequestConfig = { method: 'GET', ...baseOptions, ...options};
            const localVarHeaderParameter = {} as any;
            const localVarQueryParameter = {} as any;

            // authentication Bearer required
            // http bearer authentication required
            if (configuration && configuration.accessToken) {
                const accessToken = typeof configuration.accessToken === 'function'
                    ? await configuration.accessToken()
                    : await configuration.accessToken;
                localVarHeaderParameter["Authorization"] = "Bearer " + accessToken;
            }

            if (partNo !== undefined) {
                localVarQueryParameter['PartNo'] = partNo;
            }

            if (batch !== undefined) {
                localVarQueryParameter['Batch'] = batch;
            }

            if (availableStock !== undefined) {
                localVarQueryParameter['AvailableStock'] = availableStock;
            }

            if (currentStock !== undefined) {
                localVarQueryParameter['CurrentStock'] = currentStock;
            }

            if (location !== undefined) {
                localVarQueryParameter['Location'] = location;
            }

            if (bin !== undefined) {
                localVarQueryParameter['Bin'] = bin;
            }

            if (serial !== undefined) {
                localVarQueryParameter['Serial'] = serial;
            }

            if (aTPQty !== undefined) {
                localVarQueryParameter['ATPQty'] = aTPQty;
            }

            if (availableQOH !== undefined) {
                localVarQueryParameter['AvailableQOH'] = availableQOH;
            }

            if (isRawMaterial !== undefined) {
                localVarQueryParameter['IsRawMaterial'] = isRawMaterial;
            }

            if (lotSize !== undefined) {
                localVarQueryParameter['LotSize'] = lotSize;
            }

            if (page !== undefined) {
                localVarQueryParameter['Page'] = page;
            }

            if (pageSize !== undefined) {
                localVarQueryParameter['PageSize'] = pageSize;
            }

            if (field !== undefined) {
                localVarQueryParameter['Field'] = field;
            }

            if (order !== undefined) {
                localVarQueryParameter['Order'] = order;
            }

            if (descStr !== undefined) {
                localVarQueryParameter['DescStr'] = descStr;
            }

            const query = new URLSearchParams(localVarUrlObj.search);
            for (const key in localVarQueryParameter) {
                query.set(key, localVarQueryParameter[key]);
            }
            for (const key in options.params) {
                query.set(key, options.params[key]);
            }
            localVarUrlObj.search = (new URLSearchParams(query)).toString();
            let headersFromBaseOptions = baseOptions && baseOptions.headers ? baseOptions.headers : {};
            localVarRequestOptions.headers = {...localVarHeaderParameter, ...headersFromBaseOptions, ...options.headers};

            return {
                url: localVarUrlObj.pathname + localVarUrlObj.search + localVarUrlObj.hash,
                options: localVarRequestOptions,
            };
        },
        /**
         * 
         * @param {BDStockInput} [body] 
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        apiBDStockPagePost: async (body?: BDStockInput, options: AxiosRequestConfig = {}): Promise<RequestArgs> => {
            const localVarPath = `/api/bD_Stock/page`;
            // use dummy base URL string because the URL constructor only accepts absolute URLs.
            const localVarUrlObj = new URL(localVarPath, 'https://example.com');
            let baseOptions;
            if (configuration) {
                baseOptions = configuration.baseOptions;
            }
            const localVarRequestOptions :AxiosRequestConfig = { method: 'POST', ...baseOptions, ...options};
            const localVarHeaderParameter = {} as any;
            const localVarQueryParameter = {} as any;

            // authentication Bearer required
            // http bearer authentication required
            if (configuration && configuration.accessToken) {
                const accessToken = typeof configuration.accessToken === 'function'
                    ? await configuration.accessToken()
                    : await configuration.accessToken;
                localVarHeaderParameter["Authorization"] = "Bearer " + accessToken;
            }

            localVarHeaderParameter['Content-Type'] = 'application/json-patch+json';

            const query = new URLSearchParams(localVarUrlObj.search);
            for (const key in localVarQueryParameter) {
                query.set(key, localVarQueryParameter[key]);
            }
            for (const key in options.params) {
                query.set(key, options.params[key]);
            }
            localVarUrlObj.search = (new URLSearchParams(query)).toString();
            let headersFromBaseOptions = baseOptions && baseOptions.headers ? baseOptions.headers : {};
            localVarRequestOptions.headers = {...localVarHeaderParameter, ...headersFromBaseOptions, ...options.headers};
            const needsSerialization = (typeof body !== "string") || localVarRequestOptions.headers['Content-Type'] === 'application/json';
            localVarRequestOptions.data =  needsSerialization ? JSON.stringify(body !== undefined ? body : {}) : (body || "");

            return {
                url: localVarUrlObj.pathname + localVarUrlObj.search + localVarUrlObj.hash,
                options: localVarRequestOptions,
            };
        },
        /**
         * 
         * @param {UpdateBDStockInput} [body] 
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        apiBDStockUpdatePost: async (body?: UpdateBDStockInput, options: AxiosRequestConfig = {}): Promise<RequestArgs> => {
            const localVarPath = `/api/bD_Stock/update`;
            // use dummy base URL string because the URL constructor only accepts absolute URLs.
            const localVarUrlObj = new URL(localVarPath, 'https://example.com');
            let baseOptions;
            if (configuration) {
                baseOptions = configuration.baseOptions;
            }
            const localVarRequestOptions :AxiosRequestConfig = { method: 'POST', ...baseOptions, ...options};
            const localVarHeaderParameter = {} as any;
            const localVarQueryParameter = {} as any;

            // authentication Bearer required
            // http bearer authentication required
            if (configuration && configuration.accessToken) {
                const accessToken = typeof configuration.accessToken === 'function'
                    ? await configuration.accessToken()
                    : await configuration.accessToken;
                localVarHeaderParameter["Authorization"] = "Bearer " + accessToken;
            }

            localVarHeaderParameter['Content-Type'] = 'application/json-patch+json';

            const query = new URLSearchParams(localVarUrlObj.search);
            for (const key in localVarQueryParameter) {
                query.set(key, localVarQueryParameter[key]);
            }
            for (const key in options.params) {
                query.set(key, options.params[key]);
            }
            localVarUrlObj.search = (new URLSearchParams(query)).toString();
            let headersFromBaseOptions = baseOptions && baseOptions.headers ? baseOptions.headers : {};
            localVarRequestOptions.headers = {...localVarHeaderParameter, ...headersFromBaseOptions, ...options.headers};
            const needsSerialization = (typeof body !== "string") || localVarRequestOptions.headers['Content-Type'] === 'application/json';
            localVarRequestOptions.data =  needsSerialization ? JSON.stringify(body !== undefined ? body : {}) : (body || "");

            return {
                url: localVarUrlObj.pathname + localVarUrlObj.search + localVarUrlObj.hash,
                options: localVarRequestOptions,
            };
        },
    }
};

/**
 * BDStockApi - functional programming interface
 * @export
 */
export const BDStockApiFp = function(configuration?: Configuration) {
    return {
        /**
         * 
         * @param {AddBDStockInput} [body] 
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        async apiBDStockAddPost(body?: AddBDStockInput, options?: AxiosRequestConfig): Promise<(axios?: AxiosInstance, basePath?: string) => Promise<AxiosResponse<void>>> {
            const localVarAxiosArgs = await BDStockApiAxiosParamCreator(configuration).apiBDStockAddPost(body, options);
            return (axios: AxiosInstance = globalAxios, basePath: string = BASE_PATH) => {
                const axiosRequestArgs :AxiosRequestConfig = {...localVarAxiosArgs.options, url: basePath + localVarAxiosArgs.url};
                return axios.request(axiosRequestArgs);
            };
        },
        /**
         * 
         * @param {DeleteBDStockInput} [body] 
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        async apiBDStockDeletePost(body?: DeleteBDStockInput, options?: AxiosRequestConfig): Promise<(axios?: AxiosInstance, basePath?: string) => Promise<AxiosResponse<void>>> {
            const localVarAxiosArgs = await BDStockApiAxiosParamCreator(configuration).apiBDStockDeletePost(body, options);
            return (axios: AxiosInstance = globalAxios, basePath: string = BASE_PATH) => {
                const axiosRequestArgs :AxiosRequestConfig = {...localVarAxiosArgs.options, url: basePath + localVarAxiosArgs.url};
                return axios.request(axiosRequestArgs);
            };
        },
        /**
         * 
         * @param {number} id 主键Id
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        async apiBDStockDetailGet(id: number, options?: AxiosRequestConfig): Promise<(axios?: AxiosInstance, basePath?: string) => Promise<AxiosResponse<AdminResultBDStock>>> {
            const localVarAxiosArgs = await BDStockApiAxiosParamCreator(configuration).apiBDStockDetailGet(id, options);
            return (axios: AxiosInstance = globalAxios, basePath: string = BASE_PATH) => {
                const axiosRequestArgs :AxiosRequestConfig = {...localVarAxiosArgs.options, url: basePath + localVarAxiosArgs.url};
                return axios.request(axiosRequestArgs);
            };
        },
        /**
         * 
         * @param {string} [partNo] 
         * @param {string} [batch] 
         * @param {number} [availableStock] 
         * @param {number} [currentStock] 
         * @param {string} [location] 
         * @param {string} [bin] 
         * @param {string} [serial] 
         * @param {number} [aTPQty] 
         * @param {number} [availableQOH] 
         * @param {number} [isRawMaterial] 
         * @param {number} [lotSize] 
         * @param {number} [page] 当前页码
         * @param {number} [pageSize] 页码容量
         * @param {string} [field] 排序字段
         * @param {string} [order] 排序方向
         * @param {string} [descStr] 降序排序
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        async apiBDStockListGet(partNo?: string, batch?: string, availableStock?: number, currentStock?: number, location?: string, bin?: string, serial?: string, aTPQty?: number, availableQOH?: number, isRawMaterial?: number, lotSize?: number, page?: number, pageSize?: number, field?: string, order?: string, descStr?: string, options?: AxiosRequestConfig): Promise<(axios?: AxiosInstance, basePath?: string) => Promise<AxiosResponse<AdminResultListBDStockOutput>>> {
            const localVarAxiosArgs = await BDStockApiAxiosParamCreator(configuration).apiBDStockListGet(partNo, batch, availableStock, currentStock, location, bin, serial, aTPQty, availableQOH, isRawMaterial, lotSize, page, pageSize, field, order, descStr, options);
            return (axios: AxiosInstance = globalAxios, basePath: string = BASE_PATH) => {
                const axiosRequestArgs :AxiosRequestConfig = {...localVarAxiosArgs.options, url: basePath + localVarAxiosArgs.url};
                return axios.request(axiosRequestArgs);
            };
        },
        /**
         * 
         * @param {BDStockInput} [body] 
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        async apiBDStockPagePost(body?: BDStockInput, options?: AxiosRequestConfig): Promise<(axios?: AxiosInstance, basePath?: string) => Promise<AxiosResponse<AdminResultSqlSugarPagedListBDStockOutput>>> {
            const localVarAxiosArgs = await BDStockApiAxiosParamCreator(configuration).apiBDStockPagePost(body, options);
            return (axios: AxiosInstance = globalAxios, basePath: string = BASE_PATH) => {
                const axiosRequestArgs :AxiosRequestConfig = {...localVarAxiosArgs.options, url: basePath + localVarAxiosArgs.url};
                return axios.request(axiosRequestArgs);
            };
        },
        /**
         * 
         * @param {UpdateBDStockInput} [body] 
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        async apiBDStockUpdatePost(body?: UpdateBDStockInput, options?: AxiosRequestConfig): Promise<(axios?: AxiosInstance, basePath?: string) => Promise<AxiosResponse<void>>> {
            const localVarAxiosArgs = await BDStockApiAxiosParamCreator(configuration).apiBDStockUpdatePost(body, options);
            return (axios: AxiosInstance = globalAxios, basePath: string = BASE_PATH) => {
                const axiosRequestArgs :AxiosRequestConfig = {...localVarAxiosArgs.options, url: basePath + localVarAxiosArgs.url};
                return axios.request(axiosRequestArgs);
            };
        },
    }
};

/**
 * BDStockApi - factory interface
 * @export
 */
export const BDStockApiFactory = function (configuration?: Configuration, basePath?: string, axios?: AxiosInstance) {
    return {
        /**
         * 
         * @param {AddBDStockInput} [body] 
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        async apiBDStockAddPost(body?: AddBDStockInput, options?: AxiosRequestConfig): Promise<AxiosResponse<void>> {
            return BDStockApiFp(configuration).apiBDStockAddPost(body, options).then((request) => request(axios, basePath));
        },
        /**
         * 
         * @param {DeleteBDStockInput} [body] 
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        async apiBDStockDeletePost(body?: DeleteBDStockInput, options?: AxiosRequestConfig): Promise<AxiosResponse<void>> {
            return BDStockApiFp(configuration).apiBDStockDeletePost(body, options).then((request) => request(axios, basePath));
        },
        /**
         * 
         * @param {number} id 主键Id
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        async apiBDStockDetailGet(id: number, options?: AxiosRequestConfig): Promise<AxiosResponse<AdminResultBDStock>> {
            return BDStockApiFp(configuration).apiBDStockDetailGet(id, options).then((request) => request(axios, basePath));
        },
        /**
         * 
         * @param {string} [partNo] 
         * @param {string} [batch] 
         * @param {number} [availableStock] 
         * @param {number} [currentStock] 
         * @param {string} [location] 
         * @param {string} [bin] 
         * @param {string} [serial] 
         * @param {number} [aTPQty] 
         * @param {number} [availableQOH] 
         * @param {number} [isRawMaterial] 
         * @param {number} [lotSize] 
         * @param {number} [page] 当前页码
         * @param {number} [pageSize] 页码容量
         * @param {string} [field] 排序字段
         * @param {string} [order] 排序方向
         * @param {string} [descStr] 降序排序
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        async apiBDStockListGet(partNo?: string, batch?: string, availableStock?: number, currentStock?: number, location?: string, bin?: string, serial?: string, aTPQty?: number, availableQOH?: number, isRawMaterial?: number, lotSize?: number, page?: number, pageSize?: number, field?: string, order?: string, descStr?: string, options?: AxiosRequestConfig): Promise<AxiosResponse<AdminResultListBDStockOutput>> {
            return BDStockApiFp(configuration).apiBDStockListGet(partNo, batch, availableStock, currentStock, location, bin, serial, aTPQty, availableQOH, isRawMaterial, lotSize, page, pageSize, field, order, descStr, options).then((request) => request(axios, basePath));
        },
        /**
         * 
         * @param {BDStockInput} [body] 
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        async apiBDStockPagePost(body?: BDStockInput, options?: AxiosRequestConfig): Promise<AxiosResponse<AdminResultSqlSugarPagedListBDStockOutput>> {
            return BDStockApiFp(configuration).apiBDStockPagePost(body, options).then((request) => request(axios, basePath));
        },
        /**
         * 
         * @param {UpdateBDStockInput} [body] 
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        async apiBDStockUpdatePost(body?: UpdateBDStockInput, options?: AxiosRequestConfig): Promise<AxiosResponse<void>> {
            return BDStockApiFp(configuration).apiBDStockUpdatePost(body, options).then((request) => request(axios, basePath));
        },
    };
};

/**
 * BDStockApi - object-oriented interface
 * @export
 * @class BDStockApi
 * @extends {BaseAPI}
 */
export class BDStockApi extends BaseAPI {
    /**
     * 
     * @param {AddBDStockInput} [body] 
     * @param {*} [options] Override http request option.
     * @throws {RequiredError}
     * @memberof BDStockApi
     */
    public async apiBDStockAddPost(body?: AddBDStockInput, options?: AxiosRequestConfig) : Promise<AxiosResponse<void>> {
        return BDStockApiFp(this.configuration).apiBDStockAddPost(body, options).then((request) => request(this.axios, this.basePath));
    }
    /**
     * 
     * @param {DeleteBDStockInput} [body] 
     * @param {*} [options] Override http request option.
     * @throws {RequiredError}
     * @memberof BDStockApi
     */
    public async apiBDStockDeletePost(body?: DeleteBDStockInput, options?: AxiosRequestConfig) : Promise<AxiosResponse<void>> {
        return BDStockApiFp(this.configuration).apiBDStockDeletePost(body, options).then((request) => request(this.axios, this.basePath));
    }
    /**
     * 
     * @param {number} id 主键Id
     * @param {*} [options] Override http request option.
     * @throws {RequiredError}
     * @memberof BDStockApi
     */
    public async apiBDStockDetailGet(id: number, options?: AxiosRequestConfig) : Promise<AxiosResponse<AdminResultBDStock>> {
        return BDStockApiFp(this.configuration).apiBDStockDetailGet(id, options).then((request) => request(this.axios, this.basePath));
    }
    /**
     * 
     * @param {string} [partNo] 
     * @param {string} [batch] 
     * @param {number} [availableStock] 
     * @param {number} [currentStock] 
     * @param {string} [location] 
     * @param {string} [bin] 
     * @param {string} [serial] 
     * @param {number} [aTPQty] 
     * @param {number} [availableQOH] 
     * @param {number} [isRawMaterial] 
     * @param {number} [lotSize] 
     * @param {number} [page] 当前页码
     * @param {number} [pageSize] 页码容量
     * @param {string} [field] 排序字段
     * @param {string} [order] 排序方向
     * @param {string} [descStr] 降序排序
     * @param {*} [options] Override http request option.
     * @throws {RequiredError}
     * @memberof BDStockApi
     */
    public async apiBDStockListGet(partNo?: string, batch?: string, availableStock?: number, currentStock?: number, location?: string, bin?: string, serial?: string, aTPQty?: number, availableQOH?: number, isRawMaterial?: number, lotSize?: number, page?: number, pageSize?: number, field?: string, order?: string, descStr?: string, options?: AxiosRequestConfig) : Promise<AxiosResponse<AdminResultListBDStockOutput>> {
        return BDStockApiFp(this.configuration).apiBDStockListGet(partNo, batch, availableStock, currentStock, location, bin, serial, aTPQty, availableQOH, isRawMaterial, lotSize, page, pageSize, field, order, descStr, options).then((request) => request(this.axios, this.basePath));
    }
    /**
     * 
     * @param {BDStockInput} [body] 
     * @param {*} [options] Override http request option.
     * @throws {RequiredError}
     * @memberof BDStockApi
     */
    public async apiBDStockPagePost(body?: BDStockInput, options?: AxiosRequestConfig) : Promise<AxiosResponse<AdminResultSqlSugarPagedListBDStockOutput>> {
        return BDStockApiFp(this.configuration).apiBDStockPagePost(body, options).then((request) => request(this.axios, this.basePath));
    }
    /**
     * 
     * @param {UpdateBDStockInput} [body] 
     * @param {*} [options] Override http request option.
     * @throws {RequiredError}
     * @memberof BDStockApi
     */
    public async apiBDStockUpdatePost(body?: UpdateBDStockInput, options?: AxiosRequestConfig) : Promise<AxiosResponse<void>> {
        return BDStockApiFp(this.configuration).apiBDStockUpdatePost(body, options).then((request) => request(this.axios, this.basePath));
    }
}