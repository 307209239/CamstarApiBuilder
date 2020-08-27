// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IPrintQueueMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IPrintQueueMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      PrintQueueMaint printQueueMaint,
      PrintQueueMaint_Parameters parameters,
      PrintQueueMaint_Request request,
      out PrintQueueMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      PrintQueueMaint printQueueMaint,
      PrintQueueMaint_Parameters parameters,
      PrintQueueMaint_Request request,
      out PrintQueueMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      PrintQueueMaint printQueueMaint,
      PrintQueueMaint_Parameters parameters,
      PrintQueueMaint_Request request,
      out PrintQueueMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      PrintQueueMaint printQueueMaint,
      PrintQueueMaint_Parameters parameters,
      PrintQueueMaint_Request request,
      out PrintQueueMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      PrintQueueMaint printQueueMaint,
      PrintQueueMaint_LoadESigDetails_Parameters parameters,
      PrintQueueMaint_Request request,
      out PrintQueueMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      PrintQueueMaint printQueueMaint,
      PrintQueueMaint_Parameters parameters,
      PrintQueueMaint_Request request,
      out PrintQueueMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      PrintQueueMaint printQueueMaint,
      PrintQueueMaint_Parameters parameters,
      PrintQueueMaint_Request request,
      out PrintQueueMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      PrintQueueMaint printQueueMaint,
      PrintQueueMaint_Parameters parameters,
      PrintQueueMaint_Request request,
      out PrintQueueMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      PrintQueueMaint printQueueMaint,
      PrintQueueMaint_Parameters parameters,
      PrintQueueMaint_Request request,
      out PrintQueueMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      PrintQueueMaintMethod[] methods,
      PrintQueueMaint_Request request,
      out PrintQueueMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      PrintQueueMaint printQueueMaint,
      PrintQueueMaint_Request request,
      out PrintQueueMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      PrintQueueMaint printQueueMaint,
      PrintQueueMaint_Request request,
      out PrintQueueMaint_Result result);
  }
}
