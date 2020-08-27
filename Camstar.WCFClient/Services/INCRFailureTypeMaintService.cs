// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.INCRFailureTypeMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface INCRFailureTypeMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      NCRFailureTypeMaint nCRFailureTypeMaint,
      NCRFailureTypeMaint_Parameters parameters,
      NCRFailureTypeMaint_Request request,
      out NCRFailureTypeMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      NCRFailureTypeMaint nCRFailureTypeMaint,
      NCRFailureTypeMaint_Parameters parameters,
      NCRFailureTypeMaint_Request request,
      out NCRFailureTypeMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      NCRFailureTypeMaint nCRFailureTypeMaint,
      NCRFailureTypeMaint_Parameters parameters,
      NCRFailureTypeMaint_Request request,
      out NCRFailureTypeMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      NCRFailureTypeMaint nCRFailureTypeMaint,
      NCRFailureTypeMaint_Parameters parameters,
      NCRFailureTypeMaint_Request request,
      out NCRFailureTypeMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      NCRFailureTypeMaint nCRFailureTypeMaint,
      NCRFailureTypeMaint_LoadESigDetails_Parameters parameters,
      NCRFailureTypeMaint_Request request,
      out NCRFailureTypeMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      NCRFailureTypeMaint nCRFailureTypeMaint,
      NCRFailureTypeMaint_Parameters parameters,
      NCRFailureTypeMaint_Request request,
      out NCRFailureTypeMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      NCRFailureTypeMaint nCRFailureTypeMaint,
      NCRFailureTypeMaint_Parameters parameters,
      NCRFailureTypeMaint_Request request,
      out NCRFailureTypeMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      NCRFailureTypeMaint nCRFailureTypeMaint,
      NCRFailureTypeMaint_Parameters parameters,
      NCRFailureTypeMaint_Request request,
      out NCRFailureTypeMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      NCRFailureTypeMaint nCRFailureTypeMaint,
      NCRFailureTypeMaint_Parameters parameters,
      NCRFailureTypeMaint_Request request,
      out NCRFailureTypeMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      NCRFailureTypeMaintMethod[] methods,
      NCRFailureTypeMaint_Request request,
      out NCRFailureTypeMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      NCRFailureTypeMaint nCRFailureTypeMaint,
      NCRFailureTypeMaint_Request request,
      out NCRFailureTypeMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      NCRFailureTypeMaint nCRFailureTypeMaint,
      NCRFailureTypeMaint_Request request,
      out NCRFailureTypeMaint_Result result);
  }
}
