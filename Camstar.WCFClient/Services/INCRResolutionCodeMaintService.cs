// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.INCRResolutionCodeMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface INCRResolutionCodeMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      NCRResolutionCodeMaint nCRResolutionCodeMaint,
      NCRResolutionCodeMaint_Parameters parameters,
      NCRResolutionCodeMaint_Request request,
      out NCRResolutionCodeMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      NCRResolutionCodeMaint nCRResolutionCodeMaint,
      NCRResolutionCodeMaint_Parameters parameters,
      NCRResolutionCodeMaint_Request request,
      out NCRResolutionCodeMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      NCRResolutionCodeMaint nCRResolutionCodeMaint,
      NCRResolutionCodeMaint_Parameters parameters,
      NCRResolutionCodeMaint_Request request,
      out NCRResolutionCodeMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      NCRResolutionCodeMaint nCRResolutionCodeMaint,
      NCRResolutionCodeMaint_Parameters parameters,
      NCRResolutionCodeMaint_Request request,
      out NCRResolutionCodeMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      NCRResolutionCodeMaint nCRResolutionCodeMaint,
      NCRResolutionCodeMaint_LoadESigDetails_Parameters parameters,
      NCRResolutionCodeMaint_Request request,
      out NCRResolutionCodeMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      NCRResolutionCodeMaint nCRResolutionCodeMaint,
      NCRResolutionCodeMaint_Parameters parameters,
      NCRResolutionCodeMaint_Request request,
      out NCRResolutionCodeMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      NCRResolutionCodeMaint nCRResolutionCodeMaint,
      NCRResolutionCodeMaint_Parameters parameters,
      NCRResolutionCodeMaint_Request request,
      out NCRResolutionCodeMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      NCRResolutionCodeMaint nCRResolutionCodeMaint,
      NCRResolutionCodeMaint_Parameters parameters,
      NCRResolutionCodeMaint_Request request,
      out NCRResolutionCodeMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      NCRResolutionCodeMaint nCRResolutionCodeMaint,
      NCRResolutionCodeMaint_Parameters parameters,
      NCRResolutionCodeMaint_Request request,
      out NCRResolutionCodeMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      NCRResolutionCodeMaintMethod[] methods,
      NCRResolutionCodeMaint_Request request,
      out NCRResolutionCodeMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      NCRResolutionCodeMaint nCRResolutionCodeMaint,
      NCRResolutionCodeMaint_Request request,
      out NCRResolutionCodeMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      NCRResolutionCodeMaint nCRResolutionCodeMaint,
      NCRResolutionCodeMaint_Request request,
      out NCRResolutionCodeMaint_Result result);
  }
}
