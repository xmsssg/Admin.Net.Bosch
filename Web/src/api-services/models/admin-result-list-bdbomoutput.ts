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
import { BDBOMOutput } from './bdbomoutput';
/**
 * 全局返回结果
 * @export
 * @interface AdminResultListBDBOMOutput
 */
export interface AdminResultListBDBOMOutput {
    /**
     * 状态码
     * @type {number}
     * @memberof AdminResultListBDBOMOutput
     */
    code?: number;
    /**
     * 类型success、warning、error
     * @type {string}
     * @memberof AdminResultListBDBOMOutput
     */
    type?: string | null;
    /**
     * 错误信息
     * @type {string}
     * @memberof AdminResultListBDBOMOutput
     */
    message?: string | null;
    /**
     * 数据
     * @type {Array<BDBOMOutput>}
     * @memberof AdminResultListBDBOMOutput
     */
    result?: Array<BDBOMOutput> | null;
    /**
     * 附加数据
     * @type {any}
     * @memberof AdminResultListBDBOMOutput
     */
    extras?: any | null;
    /**
     * 时间
     * @type {Date}
     * @memberof AdminResultListBDBOMOutput
     */
    time?: Date;
}
