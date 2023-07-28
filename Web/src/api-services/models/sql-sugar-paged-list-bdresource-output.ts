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
import { BDResourceOutput } from './bdresource-output';
/**
 * 分页泛型集合
 * @export
 * @interface SqlSugarPagedListBDResourceOutput
 */
export interface SqlSugarPagedListBDResourceOutput {
    /**
     * 页码
     * @type {number}
     * @memberof SqlSugarPagedListBDResourceOutput
     */
    page?: number;
    /**
     * 页容量
     * @type {number}
     * @memberof SqlSugarPagedListBDResourceOutput
     */
    pageSize?: number;
    /**
     * 总条数
     * @type {number}
     * @memberof SqlSugarPagedListBDResourceOutput
     */
    total?: number;
    /**
     * 总页数
     * @type {number}
     * @memberof SqlSugarPagedListBDResourceOutput
     */
    totalPages?: number;
    /**
     * 当前页集合
     * @type {Array<BDResourceOutput>}
     * @memberof SqlSugarPagedListBDResourceOutput
     */
    items?: Array<BDResourceOutput> | null;
    /**
     * 是否有上一页
     * @type {boolean}
     * @memberof SqlSugarPagedListBDResourceOutput
     */
    hasPrevPage?: boolean;
    /**
     * 是否有下一页
     * @type {boolean}
     * @memberof SqlSugarPagedListBDResourceOutput
     */
    hasNextPage?: boolean;
}