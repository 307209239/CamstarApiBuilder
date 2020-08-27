// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ISalesOrderMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface ISalesOrderMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      SalesOrderMaint salesOrderMaint,
      SalesOrderMaint_Parameters parameters,
      SalesOrderMaint_Request request,
      out SalesOrderMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      SalesOrderMaint salesOrderMaint,
      SalesOrderMaint_Parameters parameters,
      SalesOrderMaint_Request request,
      out SalesOrderMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      SalesOrderMaint salesOrderMaint,
      SalesOrderMaint_Parameters parameters,
      SalesOrderMaint_Request request,
      out SalesOrderMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      SalesOrderMaint salesOrderMaint,
      SalesOrderMaint_Parameters parameters,
      SalesOrderMaint_Request request,
      out SalesOrderMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      SalesOrderMaint salesOrderMaint,
      SalesOrderMaint_LoadESigDetails_Parameters parameters,
      SalesOrderMaint_Request request,
      out SalesOrderMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      SalesOrderMaint salesOrderMaint,
      SalesOrderMaint_Parameters parameters,
      SalesOrderMaint_Request request,
      out SalesOrderMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      SalesOrderMaint salesOrderMaint,
      SalesOrderMaint_Parameters parameters,
      SalesOrderMaint_Request request,
      out SalesOrderMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      SalesOrderMaint salesOrderMaint,
      SalesOrderMaint_Parameters parameters,
      SalesOrderMaint_Request request,
      out SalesOrderMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      SalesOrderMaint salesOrderMaint,
      SalesOrderMaint_Parameters parameters,
      SalesOrderMaint_Request request,
      out SalesOrderMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      SalesOrderMaintMethod[] methods,
      SalesOrderMaint_Request request,
      out SalesOrderMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      SalesOrderMaint salesOrderMaint,
      SalesOrderMaint_Request request,
      out SalesOrderMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      SalesOrderMaint salesOrderMaint,
      SalesOrderMaint_Request request,
      out SalesOrderMaint_Result result);
  }
}
