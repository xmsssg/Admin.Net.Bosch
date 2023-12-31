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
/**
 * 
 * @export
 * @interface BDPartRoutingInput
 */
export interface BDPartRoutingInput {
    /**
     * 当前页码
     * @type {number}
     * @memberof BDPartRoutingInput
     */
    page?: number;
    /**
     * 页码容量
     * @type {number}
     * @memberof BDPartRoutingInput
     */
    pageSize?: number;
    /**
     * 排序字段
     * @type {string}
     * @memberof BDPartRoutingInput
     */
    field?: string | null;
    /**
     * 排序方向
     * @type {string}
     * @memberof BDPartRoutingInput
     */
    order?: string | null;
    /**
     * 降序排序
     * @type {string}
     * @memberof BDPartRoutingInput
     */
    descStr?: string | null;
    /**
     * 
     * @type {string}
     * @memberof BDPartRoutingInput
     */
    partRoutingNo?: string | null;
    /**
     * 
     * @type {string}
     * @memberof BDPartRoutingInput
     */
    partRoutingName?: string | null;
}
