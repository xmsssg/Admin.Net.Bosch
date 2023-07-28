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
import { BDPart } from './bdpart';
/**
 * 全局返回结果
 * @export
 * @interface AdminResultBDPart
 */
export interface AdminResultBDPart {
    /**
     * 状态码
     * @type {number}
     * @memberof AdminResultBDPart
     */
    code?: number;
    /**
     * 类型success、warning、error
     * @type {string}
     * @memberof AdminResultBDPart
     */
    type?: string | null;
    /**
     * 错误信息
     * @type {string}
     * @memberof AdminResultBDPart
     */
    message?: string | null;
    /**
     * 
     * @type {BDPart}
     * @memberof AdminResultBDPart
     */
    result?: BDPart;
    /**
     * 附加数据
     * @type {any}
     * @memberof AdminResultBDPart
     */
    extras?: any | null;
    /**
     * 时间
     * @type {Date}
     * @memberof AdminResultBDPart
     */
    time?: Date;
}