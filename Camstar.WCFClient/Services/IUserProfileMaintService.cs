// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IUserProfileMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IUserProfileMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      UserProfileMaint userProfileMaint,
      UserProfileMaint_Parameters parameters,
      UserProfileMaint_Request request,
      out UserProfileMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      UserProfileMaint userProfileMaint,
      UserProfileMaint_Parameters parameters,
      UserProfileMaint_Request request,
      out UserProfileMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      UserProfileMaint userProfileMaint,
      UserProfileMaint_Parameters parameters,
      UserProfileMaint_Request request,
      out UserProfileMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      UserProfileMaint userProfileMaint,
      UserProfileMaint_Parameters parameters,
      UserProfileMaint_Request request,
      out UserProfileMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      UserProfileMaint userProfileMaint,
      UserProfileMaint_LoadESigDetails_Parameters parameters,
      UserProfileMaint_Request request,
      out UserProfileMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      UserProfileMaint userProfileMaint,
      UserProfileMaint_Parameters parameters,
      UserProfileMaint_Request request,
      out UserProfileMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      UserProfileMaint userProfileMaint,
      UserProfileMaint_Parameters parameters,
      UserProfileMaint_Request request,
      out UserProfileMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      UserProfileMaint userProfileMaint,
      UserProfileMaint_Parameters parameters,
      UserProfileMaint_Request request,
      out UserProfileMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      UserProfileMaint userProfileMaint,
      UserProfileMaint_Parameters parameters,
      UserProfileMaint_Request request,
      out UserProfileMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      UserProfileMaintMethod[] methods,
      UserProfileMaint_Request request,
      out UserProfileMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      UserProfileMaint userProfileMaint,
      UserProfileMaint_Request request,
      out UserProfileMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      UserProfileMaint userProfileMaint,
      UserProfileMaint_Request request,
      out UserProfileMaint_Result result);
  }
}
