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
 * 资源设备表
 * @export
 * @interface BDResource
 */
export interface BDResource {
    /**
     * 雪花Id
     * @type {number}
     * @memberof BDResource
     */
    id?: number;
    /**
     * 创建时间
     * @type {Date}
     * @memberof BDResource
     */
    createTime?: Date | null;
    /**
     * 更新时间
     * @type {Date}
     * @memberof BDResource
     */
    updateTime?: Date | null;
    /**
     * 创建者Id
     * @type {number}
     * @memberof BDResource
     */
    createUserId?: number | null;
    /**
     * 修改者Id
     * @type {number}
     * @memberof BDResource
     */
    updateUserId?: number | null;
    /**
     * 软删除
     * @type {boolean}
     * @memberof BDResource
     */
    isDelete?: boolean;
    /**
     * 资源Id，唯一标识
     * @type {string}
     * @memberof BDResource
     */
    resID?: string | null;
    /**
     * 部门Id，关联部门表
     * @type {string}
     * @memberof BDResource
     */
    depID?: string | null;
    /**
     * 资源设备编码
     * @type {string}
     * @memberof BDResource
     */
    resNo?: string | null;
    /**
     * 资源设备名称
     * @type {string}
     * @memberof BDResource
     */
    resName?: string | null;
    /**
     * 设备描述
     * @type {string}
     * @memberof BDResource
     */
    resDesc?: string | null;
    /**
     * 已弃用Status
     * @type {number}
     * @memberof BDResource
     */
    status?: number | null;
    /**
     * 设备类型
     * @type {number}
     * @memberof BDResource
     */
    type?: number | null;
    /**
     * 设备产能类型
     * @type {number}
     * @memberof BDResource
     */
    resType?: number | null;
    /**
     * 是否默认，默认为0
     * @type {boolean}
     * @memberof BDResource
     */
    isDefault?: boolean;
    /**
     * 工作中心编号
     * @type {string}
     * @memberof BDResource
     */
    workCenterNo?: string | null;
    /**
     * 设备数量
     * @type {number}
     * @memberof BDResource
     */
    units?: number | null;
    /**
     * 已弃用Programmable
     * @type {number}
     * @memberof BDResource
     */
    programmable?: number | null;
    /**
     * 已弃用IsSeparable
     * @type {number}
     * @memberof BDResource
     */
    isSeparable?: number | null;
    /**
     * 设备是否可用
     * @type {number}
     * @memberof BDResource
     */
    isAvailable?: number | null;
    /**
     * 是否是热处理设备(已弃用)
     * @type {number}
     * @memberof BDResource
     */
    isHeattreat?: number | null;
    /**
     * (Overtime已弃用)
     * @type {number}
     * @memberof BDResource
     */
    overtime?: number | null;
    /**
     * 组织编码
     * @type {string}
     * @memberof BDResource
     */
    orgID?: string | null;
    /**
     * 加工时间
     * @type {number}
     * @memberof BDResource
     */
    processTime?: number | null;
    /**
     * 准备时间1
     * @type {number}
     * @memberof BDResource
     */
    setuptime1?: number | null;
    /**
     * 准备时间2
     * @type {number}
     * @memberof BDResource
     */
    setuptime2?: number | null;
    /**
     * 准备时间3
     * @type {number}
     * @memberof BDResource
     */
    setuptime3?: number | null;
    /**
     * 共用编码
     * @type {string}
     * @memberof BDResource
     */
    versionSign?: string | null;
    /**
     * (isOld已弃用)
     * @type {number}
     * @memberof BDResource
     */
    isOld?: number | null;
}
