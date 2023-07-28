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
import { BDDepartment } from './bddepartment';
/**
 * 全局返回结果
 * @export
 * @interface AdminResultBDDepartment
 */
export interface AdminResultBDDepartment {
    /**
     * 状态码
     * @type {number}
     * @memberof AdminResultBDDepartment
     */
    code?: number;
    /**
     * 类型success、warning、error
     * @type {string}
     * @memberof AdminResultBDDepartment
     */
    type?: string | null;
    /**
     * 错误信息
     * @type {string}
     * @memberof AdminResultBDDepartment
     */
    message?: string | null;
    /**
     * 
     * @type {BDDepartment}
     * @memberof AdminResultBDDepartment
     */
    result?: BDDepartment;
    /**
     * 附加数据
     * @type {any}
     * @memberof AdminResultBDDepartment
     */
    extras?: any | null;
    /**
     * 时间
     * @type {Date}
     * @memberof AdminResultBDDepartment
     */
    time?: Date;
}