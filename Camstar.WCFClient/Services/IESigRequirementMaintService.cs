// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IESigRequirementMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IESigRequirementMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      ESigRequirementMaint eSigRequirementMaint,
      ESigRequirementMaint_Parameters parameters,
      ESigRequirementMaint_Request request,
      out ESigRequirementMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      ESigRequirementMaint eSigRequirementMaint,
      ESigRequirementMaint_Parameters parameters,
      ESigRequirementMaint_Request request,
      out ESigRequirementMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ESigRequirementMaint eSigRequirementMaint,
      ESigRequirementMaint_Parameters parameters,
      ESigRequirementMaint_Request request,
      out ESigRequirementMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ESigRequirementMaint eSigRequirementMaint,
      ESigRequirementMaint_Parameters parameters,
      ESigRequirementMaint_Request request,
      out ESigRequirementMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ESigRequirementMaint eSigRequirementMaint,
      ESigRequirementMaint_LoadESigDetails_Parameters parameters,
      ESigRequirementMaint_Request request,
      out ESigRequirementMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      ESigRequirementMaint eSigRequirementMaint,
      ESigRequirementMaint_Parameters parameters,
      ESigRequirementMaint_Request request,
      out ESigRequirementMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      ESigRequirementMaint eSigRequirementMaint,
      ESigRequirementMaint_Parameters parameters,
      ESigRequirementMaint_Request request,
      out ESigRequirementMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      ESigRequirementMaint eSigRequirementMaint,
      ESigRequirementMaint_Parameters parameters,
      ESigRequirementMaint_Request request,
      out ESigRequirementMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      ESigRequirementMaint eSigRequirementMaint,
      ESigRequirementMaint_Parameters parameters,
      ESigRequirementMaint_Request request,
      out ESigRequirementMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ESigRequirementMaintMethod[] methods,
      ESigRequirementMaint_Request request,
      out ESigRequirementMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ESigRequirementMaint eSigRequirementMaint,
      ESigRequirementMaint_Request request,
      out ESigRequirementMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ESigRequirementMaint eSigRequirementMaint,
      ESigRequirementMaint_Request request,
      out ESigRequirementMaint_Result result);
  }
}
