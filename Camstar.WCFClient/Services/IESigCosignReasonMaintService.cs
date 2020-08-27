// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IESigCosignReasonMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IESigCosignReasonMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      ESigCosignReasonMaint eSigCosignReasonMaint,
      ESigCosignReasonMaint_Parameters parameters,
      ESigCosignReasonMaint_Request request,
      out ESigCosignReasonMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      ESigCosignReasonMaint eSigCosignReasonMaint,
      ESigCosignReasonMaint_Parameters parameters,
      ESigCosignReasonMaint_Request request,
      out ESigCosignReasonMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ESigCosignReasonMaint eSigCosignReasonMaint,
      ESigCosignReasonMaint_Parameters parameters,
      ESigCosignReasonMaint_Request request,
      out ESigCosignReasonMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ESigCosignReasonMaint eSigCosignReasonMaint,
      ESigCosignReasonMaint_Parameters parameters,
      ESigCosignReasonMaint_Request request,
      out ESigCosignReasonMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ESigCosignReasonMaint eSigCosignReasonMaint,
      ESigCosignReasonMaint_LoadESigDetails_Parameters parameters,
      ESigCosignReasonMaint_Request request,
      out ESigCosignReasonMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      ESigCosignReasonMaint eSigCosignReasonMaint,
      ESigCosignReasonMaint_Parameters parameters,
      ESigCosignReasonMaint_Request request,
      out ESigCosignReasonMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      ESigCosignReasonMaint eSigCosignReasonMaint,
      ESigCosignReasonMaint_Parameters parameters,
      ESigCosignReasonMaint_Request request,
      out ESigCosignReasonMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      ESigCosignReasonMaint eSigCosignReasonMaint,
      ESigCosignReasonMaint_Parameters parameters,
      ESigCosignReasonMaint_Request request,
      out ESigCosignReasonMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      ESigCosignReasonMaint eSigCosignReasonMaint,
      ESigCosignReasonMaint_Parameters parameters,
      ESigCosignReasonMaint_Request request,
      out ESigCosignReasonMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ESigCosignReasonMaintMethod[] methods,
      ESigCosignReasonMaint_Request request,
      out ESigCosignReasonMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ESigCosignReasonMaint eSigCosignReasonMaint,
      ESigCosignReasonMaint_Request request,
      out ESigCosignReasonMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ESigCosignReasonMaint eSigCosignReasonMaint,
      ESigCosignReasonMaint_Request request,
      out ESigCosignReasonMaint_Result result);
  }
}
