/*
                           _ooOoo_
                          o8888888o
                          88" . "88
                          (| -_- |)
                          O\  =  /O
                       ____/`---'\____
                     .'  \\|     |//  `.
                    /  \\|||  :  |||//  \
                   /  _||||| -:- |||||-  \
                   |   | \\\  -  /// |   |
                   | \_|  ''\---/''  |   |
                   \  .-\__  `-`  ___/-. /
                 ___`. .'  /--.--\  `. . __
              ."" '<  `.___\_<|>_/___.'  >'"".
             | | :  `- \`.;`\ _ /`;.`/ - ` : | |
             \  \ `-.   \_ __\ /__ _/   .-` /  /
        ======`-.____`-.___\_____/___.-`____.-'======
                           `=---='
        ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
                 佛祖保佑       永无BUG
*/
/**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：{Comment}                                                    
*│　作    者：{Author}                                              
*│　版    本：1.0   模板代码自动生成                                              
*│　创建时间：{GeneratorTime}                           
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间： NSql2Table.Services                                   
*│　接口名称： ISqltemlateRepository                                      
*└──────────────────────────────────────────────────────────────┘
*/
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Http;
using NetCore.Dal.Models;
using NetCore.Dal.Services;
using NSql2Table.Models;
using NSql2Table.Models.InputModels;

namespace NSql2Table.Services
{
    public interface ISqltemlateService : IService<Sqltemlate>
    {
        /// <summary>
        /// 保存
        /// </summary>
        /// <returns></returns>
        bool Save(SqlTemplateDto dto);

        Page<Sqltemlate> Paging(PagingInfo page);

        SqlTemplateDto Fetch(int id);

        /// <summary>
        /// 保存
        /// </summary>
        /// <returns></returns>
        PageObject<object> Search(IFormCollection fc);
    }
}