// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IWorkCenterMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IWorkCenterMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      WorkCenterMaint workCenterMaint,
      WorkCenterMaint_Parameters parameters,
      WorkCenterMaint_Request request,
      out WorkCenterMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      WorkCenterMaint workCenterMaint,
      WorkCenterMaint_Parameters parameters,
      WorkCenterMaint_Request request,
      out WorkCenterMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      WorkCenterMaint workCenterMaint,
      WorkCenterMaint_Parameters parameters,
      WorkCenterMaint_Request request,
      out WorkCenterMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      WorkCenterMaint workCenterMaint,
      WorkCenterMaint_Parameters parameters,
      WorkCenterMaint_Request request,
      out WorkCenterMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      WorkCenterMaint workCenterMaint,
      WorkCenterMaint_LoadESigDetails_Parameters parameters,
      WorkCenterMaint_Request request,
      out WorkCenterMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      WorkCenterMaint workCenterMaint,
      WorkCenterMaint_Parameters parameters,
      WorkCenterMaint_Request request,
      out WorkCenterMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      WorkCenterMaint workCenterMaint,
      WorkCenterMaint_Parameters parameters,
      WorkCenterMaint_Request request,
      out WorkCenterMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      WorkCenterMaint workCenterMaint,
      WorkCenterMaint_Parameters parameters,
      WorkCenterMaint_Request request,
      out WorkCenterMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      WorkCenterMaint workCenterMaint,
      WorkCenterMaint_Parameters parameters,
      WorkCenterMaint_Request request,
      out WorkCenterMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      WorkCenterMaintMethod[] methods,
      WorkCenterMaint_Request request,
      out WorkCenterMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      WorkCenterMaint workCenterMaint,
      WorkCenterMaint_Request request,
      out WorkCenterMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      WorkCenterMaint workCenterMaint,
      WorkCenterMaint_Request request,
      out WorkCenterMaint_Result result);
  }
}
