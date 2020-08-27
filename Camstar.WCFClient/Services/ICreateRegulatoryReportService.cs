// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ICreateRegulatoryReportService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface ICreateRegulatoryReportService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      CreateRegulatoryReport createRegulatoryReport,
      CreateRegulatoryReport_Parameters parameters,
      CreateRegulatoryReport_Request request,
      out CreateRegulatoryReport_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      CreateRegulatoryReport createRegulatoryReport,
      CreateRegulatoryReport_Parameters parameters,
      CreateRegulatoryReport_Request request,
      out CreateRegulatoryReport_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      CreateRegulatoryReport createRegulatoryReport,
      CreateRegulatoryReport_Parameters parameters,
      CreateRegulatoryReport_Request request,
      out CreateRegulatoryReport_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      CreateRegulatoryReport createRegulatoryReport,
      CreateRegulatoryReport_Parameters parameters,
      CreateRegulatoryReport_Request request,
      out CreateRegulatoryReport_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      CreateRegulatoryReport createRegulatoryReport,
      CreateRegulatoryReport_Parameters parameters,
      CreateRegulatoryReport_Request request,
      out CreateRegulatoryReport_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      CreateRegulatoryReport createRegulatoryReport,
      CreateRegulatoryReport_Parameters parameters,
      CreateRegulatoryReport_Request request,
      out CreateRegulatoryReport_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      CreateRegulatoryReport createRegulatoryReport,
      CreateRegulatoryReport_Parameters parameters,
      CreateRegulatoryReport_Request request,
      out CreateRegulatoryReport_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      CreateRegulatoryReport createRegulatoryReport,
      CreateRegulatoryReport_Parameters parameters,
      CreateRegulatoryReport_Request request,
      out CreateRegulatoryReport_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      CreateRegulatoryReportMethod[] methods,
      CreateRegulatoryReport_Request request,
      out CreateRegulatoryReport_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      CreateRegulatoryReport createRegulatoryReport,
      CreateRegulatoryReport_Request request,
      out CreateRegulatoryReport_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      CreateRegulatoryReport createRegulatoryReport,
      CreateRegulatoryReport_Request request,
      out CreateRegulatoryReport_Result result);
  }
}
