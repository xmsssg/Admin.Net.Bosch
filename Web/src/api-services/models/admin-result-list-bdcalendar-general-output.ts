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
import { BDCalendarGeneralOutput } from './bdcalendar-general-output';
/**
 * 全局返回结果
 * @export
 * @interface AdminResultListBDCalendarGeneralOutput
 */
export interface AdminResultListBDCalendarGeneralOutput {
    /**
     * 状态码
     * @type {number}
     * @memberof AdminResultListBDCalendarGeneralOutput
     */
    code?: number;
    /**
     * 类型success、warning、error
     * @type {string}
     * @memberof AdminResultListBDCalendarGeneralOutput
     */
    type?: string | null;
    /**
     * 错误信息
     * @type {string}
     * @memberof AdminResultListBDCalendarGeneralOutput
     */
    message?: string | null;
    /**
     * 数据
     * @type {Array<BDCalendarGeneralOutput>}
     * @memberof AdminResultListBDCalendarGeneralOutput
     */
    result?: Array<BDCalendarGeneralOutput> | null;
    /**
     * 附加数据
     * @type {any}
     * @memberof AdminResultListBDCalendarGeneralOutput
     */
    extras?: any | null;
    /**
     * 时间
     * @type {Date}
     * @memberof AdminResultListBDCalendarGeneralOutput
     */
    time?: Date;
}