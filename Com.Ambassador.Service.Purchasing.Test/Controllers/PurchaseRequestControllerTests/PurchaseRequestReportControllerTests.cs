﻿using Com.Ambassador.Service.Purchasing.Test.DataUtils.PurchaseRequestDataUtils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Com.Ambassador.Service.Purchasing.Test.Controllers.PurchaseRequestControllerTests
{
    //[Collection("TestServerFixture Collection")]
    public class PurchaseRequestReportControllerTests
    {
        //private const string MediaType = "application/json";
        //private readonly string URI = "v1/purchase-requests/monitoring";

        //private TestServerFixture TestFixture { get; set; }

        //private HttpClient Client
        //{
        //    get { return this.TestFixture.Client; }
        //}

        //protected PurchaseRequestDataUtil DataUtil
        //{
        //    get { return (PurchaseRequestDataUtil)this.TestFixture.Service.GetService(typeof(PurchaseRequestDataUtil)); }
        //}

        //public PurchaseRequestReportControllerTests(TestServerFixture fixture)
        //{
        //    TestFixture = fixture;
        //}

        //[Fact]
        //public async Task Should_Success_Get_Report()
        //{
        //    var response = await this.Client.GetAsync(URI+"?page=1&size=25");
        //    Assert.Equal(HttpStatusCode.OK, response.StatusCode);

        //    var json = await response.Content.ReadAsStringAsync();
        //    Dictionary<string, object> result = JsonConvert.DeserializeObject<Dictionary<string, object>>(json.ToString());

        //    Assert.True(result.ContainsKey("apiVersion"));
        //    Assert.True(result.ContainsKey("message"));
        //    Assert.True(result.ContainsKey("data"));
        //    Assert.Equal("JArray", result["data"].GetType().Name);
        //}

        //[Fact]
        //public async Task Should_Success_Get_Report_Excel()
        //{
        //    var response = await this.Client.GetAsync(URI + "/download");
        //    Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        //}

        //[Fact]
        //public async Task Should_Success_Get_Report_byUser()
        //{
        //    var response = await this.Client.GetAsync(URI + "/by-user?page=1&size=25");
        //    Assert.Equal(HttpStatusCode.OK, response.StatusCode);

        //    var json = await response.Content.ReadAsStringAsync();
        //    Dictionary<string, object> result = JsonConvert.DeserializeObject<Dictionary<string, object>>(json.ToString());

        //    Assert.True(result.ContainsKey("apiVersion"));
        //    Assert.True(result.ContainsKey("message"));
        //    Assert.True(result.ContainsKey("data"));
        //    Assert.Equal("JArray", result["data"].GetType().Name);
        //}

        //[Fact]
        //public async Task Should_Success_Get_Report_Excel_byUser()
        //{
        //    var response = await this.Client.GetAsync(URI + "/by-user/download");
        //    Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        //}

        //[Fact]
        //public async Task Should_Error_Get_Report_byUser()
        //{
        //    var response = await this.Client.GetAsync(URI + "/by-user");
        //    Assert.Equal(HttpStatusCode.InternalServerError, response.StatusCode);
        //}

        //[Fact]
        //public async Task Should_Error_Get_Report()
        //{
        //    var response = await this.Client.GetAsync(URI);
        //    Assert.Equal(HttpStatusCode.InternalServerError, response.StatusCode);
        //}
    }
}
