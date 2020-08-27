// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IProcessTimerTypeMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IProcessTimerTypeMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      ProcessTimerTypeMaint processTimerTypeMaint,
      ProcessTimerTypeMaint_Parameters parameters,
      ProcessTimerTypeMaint_Request request,
      out ProcessTimerTypeMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      ProcessTimerTypeMaint processTimerTypeMaint,
      ProcessTimerTypeMaint_Parameters parameters,
      ProcessTimerTypeMaint_Request request,
      out ProcessTimerTypeMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ProcessTimerTypeMaint processTimerTypeMaint,
      ProcessTimerTypeMaint_Parameters parameters,
      ProcessTimerTypeMaint_Request request,
      out ProcessTimerTypeMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ProcessTimerTypeMaint processTimerTypeMaint,
      ProcessTimerTypeMaint_Parameters parameters,
      ProcessTimerTypeMaint_Request request,
      out ProcessTimerTypeMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ProcessTimerTypeMaint processTimerTypeMaint,
      ProcessTimerTypeMaint_LoadESigDetails_Parameters parameters,
      ProcessTimerTypeMaint_Request request,
      out ProcessTimerTypeMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      ProcessTimerTypeMaint processTimerTypeMaint,
      ProcessTimerTypeMaint_Parameters parameters,
      ProcessTimerTypeMaint_Request request,
      out ProcessTimerTypeMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      ProcessTimerTypeMaint processTimerTypeMaint,
      ProcessTimerTypeMaint_Parameters parameters,
      ProcessTimerTypeMaint_Request request,
      out ProcessTimerTypeMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      ProcessTimerTypeMaint processTimerTypeMaint,
      ProcessTimerTypeMaint_Parameters parameters,
      ProcessTimerTypeMaint_Request request,
      out ProcessTimerTypeMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      ProcessTimerTypeMaint processTimerTypeMaint,
      ProcessTimerTypeMaint_Parameters parameters,
      ProcessTimerTypeMaint_Request request,
      out ProcessTimerTypeMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ProcessTimerTypeMaintMethod[] methods,
      ProcessTimerTypeMaint_Request request,
      out ProcessTimerTypeMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ProcessTimerTypeMaint processTimerTypeMaint,
      ProcessTimerTypeMaint_Request request,
      out ProcessTimerTypeMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ProcessTimerTypeMaint processTimerTypeMaint,
      ProcessTimerTypeMaint_Request request,
      out ProcessTimerTypeMaint_Result result);
  }
}
