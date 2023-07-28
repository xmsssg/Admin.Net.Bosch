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
 * 换型矩阵表
 * @export
 * @interface BDChangeMatrix
 */
export interface BDChangeMatrix {
    /**
     * 雪花Id
     * @type {number}
     * @memberof BDChangeMatrix
     */
    id?: number;
    /**
     * 创建时间
     * @type {Date}
     * @memberof BDChangeMatrix
     */
    createTime?: Date | null;
    /**
     * 更新时间
     * @type {Date}
     * @memberof BDChangeMatrix
     */
    updateTime?: Date | null;
    /**
     * 创建者Id
     * @type {number}
     * @memberof BDChangeMatrix
     */
    createUserId?: number | null;
    /**
     * 修改者Id
     * @type {number}
     * @memberof BDChangeMatrix
     */
    updateUserId?: number | null;
    /**
     * 软删除
     * @type {boolean}
     * @memberof BDChangeMatrix
     */
    isDelete?: boolean;
    /**
     * 是否清粉
     * @type {number}
     * @memberof BDChangeMatrix
     */
    isChange?: number;
    /**
     * 清粉时间
     * @type {number}
     * @memberof BDChangeMatrix
     */
    clearPowder?: number | null;
    /**
     * 不清粉时间
     * @type {number}
     * @memberof BDChangeMatrix
     */
    noClearPowder?: number | null;
    /**
     * OrgId
     * @type {string}
     * @memberof BDChangeMatrix
     */
    orgId?: string | null;
}
