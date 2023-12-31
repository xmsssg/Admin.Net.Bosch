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
 * @interface BDMachineThird
 */
export interface BDMachineThird {
    /**
     * 雪花Id
     * @type {number}
     * @memberof BDMachineThird
     */
    id?: number;
    /**
     * 创建时间
     * @type {Date}
     * @memberof BDMachineThird
     */
    createTime?: Date | null;
    /**
     * 更新时间
     * @type {Date}
     * @memberof BDMachineThird
     */
    updateTime?: Date | null;
    /**
     * 创建者Id
     * @type {number}
     * @memberof BDMachineThird
     */
    createUserId?: number | null;
    /**
     * 修改者Id
     * @type {number}
     * @memberof BDMachineThird
     */
    updateUserId?: number | null;
    /**
     * 软删除
     * @type {boolean}
     * @memberof BDMachineThird
     */
    isDelete?: boolean;
    /**
     * 分组编码
     * @type {string}
     * @memberof BDMachineThird
     */
    groupNo?: string | null;
    /**
     * 分组描述
     * @type {string}
     * @memberof BDMachineThird
     */
    groupDesc?: string | null;
    /**
     * 设备编码
     * @type {string}
     * @memberof BDMachineThird
     */
    resNo?: string | null;
    /**
     * OrgId
     * @type {string}
     * @memberof BDMachineThird
     */
    orgId?: string | null;
    /**
     * 分组类型
     * @type {number}
     * @memberof BDMachineThird
     */
    machineType?: number | null;
    /**
     * 压机属性(单料/双料)
     * @type {number}
     * @memberof BDMachineThird
     */
    maetype?: number | null;
}
