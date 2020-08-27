// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IESigRoleGroupMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IESigRoleGroupMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      ESigRoleGroupMaint eSigRoleGroupMaint,
      ESigRoleGroupMaint_Parameters parameters,
      ESigRoleGroupMaint_Request request,
      out ESigRoleGroupMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      ESigRoleGroupMaint eSigRoleGroupMaint,
      ESigRoleGroupMaint_Parameters parameters,
      ESigRoleGroupMaint_Request request,
      out ESigRoleGroupMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ESigRoleGroupMaint eSigRoleGroupMaint,
      ESigRoleGroupMaint_Parameters parameters,
      ESigRoleGroupMaint_Request request,
      out ESigRoleGroupMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ESigRoleGroupMaint eSigRoleGroupMaint,
      ESigRoleGroupMaint_Parameters parameters,
      ESigRoleGroupMaint_Request request,
      out ESigRoleGroupMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ESigRoleGroupMaint eSigRoleGroupMaint,
      ESigRoleGroupMaint_LoadESigDetails_Parameters parameters,
      ESigRoleGroupMaint_Request request,
      out ESigRoleGroupMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      ESigRoleGroupMaint eSigRoleGroupMaint,
      ESigRoleGroupMaint_Parameters parameters,
      ESigRoleGroupMaint_Request request,
      out ESigRoleGroupMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      ESigRoleGroupMaint eSigRoleGroupMaint,
      ESigRoleGroupMaint_Parameters parameters,
      ESigRoleGroupMaint_Request request,
      out ESigRoleGroupMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      ESigRoleGroupMaint eSigRoleGroupMaint,
      ESigRoleGroupMaint_Parameters parameters,
      ESigRoleGroupMaint_Request request,
      out ESigRoleGroupMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      ESigRoleGroupMaint eSigRoleGroupMaint,
      ESigRoleGroupMaint_Parameters parameters,
      ESigRoleGroupMaint_Request request,
      out ESigRoleGroupMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ESigRoleGroupMaintMethod[] methods,
      ESigRoleGroupMaint_Request request,
      out ESigRoleGroupMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ESigRoleGroupMaint eSigRoleGroupMaint,
      ESigRoleGroupMaint_Request request,
      out ESigRoleGroupMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ESigRoleGroupMaint eSigRoleGroupMaint,
      ESigRoleGroupMaint_Request request,
      out ESigRoleGroupMaint_Result result);
  }
}
