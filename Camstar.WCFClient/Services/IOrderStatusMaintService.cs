// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IOrderStatusMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IOrderStatusMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      OrderStatusMaint orderStatusMaint,
      OrderStatusMaint_Parameters parameters,
      OrderStatusMaint_Request request,
      out OrderStatusMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      OrderStatusMaint orderStatusMaint,
      OrderStatusMaint_Parameters parameters,
      OrderStatusMaint_Request request,
      out OrderStatusMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      OrderStatusMaint orderStatusMaint,
      OrderStatusMaint_Parameters parameters,
      OrderStatusMaint_Request request,
      out OrderStatusMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      OrderStatusMaint orderStatusMaint,
      OrderStatusMaint_Parameters parameters,
      OrderStatusMaint_Request request,
      out OrderStatusMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      OrderStatusMaint orderStatusMaint,
      OrderStatusMaint_LoadESigDetails_Parameters parameters,
      OrderStatusMaint_Request request,
      out OrderStatusMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      OrderStatusMaint orderStatusMaint,
      OrderStatusMaint_Parameters parameters,
      OrderStatusMaint_Request request,
      out OrderStatusMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      OrderStatusMaint orderStatusMaint,
      OrderStatusMaint_Parameters parameters,
      OrderStatusMaint_Request request,
      out OrderStatusMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      OrderStatusMaint orderStatusMaint,
      OrderStatusMaint_Parameters parameters,
      OrderStatusMaint_Request request,
      out OrderStatusMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      OrderStatusMaint orderStatusMaint,
      OrderStatusMaint_Parameters parameters,
      OrderStatusMaint_Request request,
      out OrderStatusMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      OrderStatusMaintMethod[] methods,
      OrderStatusMaint_Request request,
      out OrderStatusMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      OrderStatusMaint orderStatusMaint,
      OrderStatusMaint_Request request,
      out OrderStatusMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      OrderStatusMaint orderStatusMaint,
      OrderStatusMaint_Request request,
      out OrderStatusMaint_Result result);
  }
}
