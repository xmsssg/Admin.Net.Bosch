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
import { BDPartOutput } from './bdpart-output';
/**
 * 分页泛型集合
 * @export
 * @interface SqlSugarPagedListBDPartOutput
 */
export interface SqlSugarPagedListBDPartOutput {
    /**
     * 页码
     * @type {number}
     * @memberof SqlSugarPagedListBDPartOutput
     */
    page?: number;
    /**
     * 页容量
     * @type {number}
     * @memberof SqlSugarPagedListBDPartOutput
     */
    pageSize?: number;
    /**
     * 总条数
     * @type {number}
     * @memberof SqlSugarPagedListBDPartOutput
     */
    total?: number;
    /**
     * 总页数
     * @type {number}
     * @memberof SqlSugarPagedListBDPartOutput
     */
    totalPages?: number;
    /**
     * 当前页集合
     * @type {Array<BDPartOutput>}
     * @memberof SqlSugarPagedListBDPartOutput
     */
    items?: Array<BDPartOutput> | null;
    /**
     * 是否有上一页
     * @type {boolean}
     * @memberof SqlSugarPagedListBDPartOutput
     */
    hasPrevPage?: boolean;
    /**
     * 是否有下一页
     * @type {boolean}
     * @memberof SqlSugarPagedListBDPartOutput
     */
    hasNextPage?: boolean;
}