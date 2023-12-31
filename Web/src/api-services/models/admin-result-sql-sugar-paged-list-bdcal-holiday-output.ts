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
import { SqlSugarPagedListBDCalHolidayOutput } from './sql-sugar-paged-list-bdcal-holiday-output';
/**
 * 全局返回结果
 * @export
 * @interface AdminResultSqlSugarPagedListBDCalHolidayOutput
 */
export interface AdminResultSqlSugarPagedListBDCalHolidayOutput {
    /**
     * 状态码
     * @type {number}
     * @memberof AdminResultSqlSugarPagedListBDCalHolidayOutput
     */
    code?: number;
    /**
     * 类型success、warning、error
     * @type {string}
     * @memberof AdminResultSqlSugarPagedListBDCalHolidayOutput
     */
    type?: string | null;
    /**
     * 错误信息
     * @type {string}
     * @memberof AdminResultSqlSugarPagedListBDCalHolidayOutput
     */
    message?: string | null;
    /**
     * 
     * @type {SqlSugarPagedListBDCalHolidayOutput}
     * @memberof AdminResultSqlSugarPagedListBDCalHolidayOutput
     */
    result?: SqlSugarPagedListBDCalHolidayOutput;
    /**
     * 附加数据
     * @type {any}
     * @memberof AdminResultSqlSugarPagedListBDCalHolidayOutput
     */
    extras?: any | null;
    /**
     * 时间
     * @type {Date}
     * @memberof AdminResultSqlSugarPagedListBDCalHolidayOutput
     */
    time?: Date;
}
