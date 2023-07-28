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
import { BDChangeMatrixOutput } from './bdchange-matrix-output';
/**
 * 全局返回结果
 * @export
 * @interface AdminResultListBDChangeMatrixOutput
 */
export interface AdminResultListBDChangeMatrixOutput {
    /**
     * 状态码
     * @type {number}
     * @memberof AdminResultListBDChangeMatrixOutput
     */
    code?: number;
    /**
     * 类型success、warning、error
     * @type {string}
     * @memberof AdminResultListBDChangeMatrixOutput
     */
    type?: string | null;
    /**
     * 错误信息
     * @type {string}
     * @memberof AdminResultListBDChangeMatrixOutput
     */
    message?: string | null;
    /**
     * 数据
     * @type {Array<BDChangeMatrixOutput>}
     * @memberof AdminResultListBDChangeMatrixOutput
     */
    result?: Array<BDChangeMatrixOutput> | null;
    /**
     * 附加数据
     * @type {any}
     * @memberof AdminResultListBDChangeMatrixOutput
     */
    extras?: any | null;
    /**
     * 时间
     * @type {Date}
     * @memberof AdminResultListBDChangeMatrixOutput
     */
    time?: Date;
}
