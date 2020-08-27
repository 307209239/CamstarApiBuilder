// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IV4_SystemSecurityGroupMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IV4_SystemSecurityGroupMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      V4_SystemSecurityGroupMaint v4_SystemSecurityGroupMaint,
      V4_SystemSecurityGroupMaint_Parameters parameters,
      V4_SystemSecurityGroupMaint_Request request,
      out V4_SystemSecurityGroupMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      V4_SystemSecurityGroupMaint v4_SystemSecurityGroupMaint,
      V4_SystemSecurityGroupMaint_Parameters parameters,
      V4_SystemSecurityGroupMaint_Request request,
      out V4_SystemSecurityGroupMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      V4_SystemSecurityGroupMaint v4_SystemSecurityGroupMaint,
      V4_SystemSecurityGroupMaint_Parameters parameters,
      V4_SystemSecurityGroupMaint_Request request,
      out V4_SystemSecurityGroupMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      V4_SystemSecurityGroupMaint v4_SystemSecurityGroupMaint,
      V4_SystemSecurityGroupMaint_Parameters parameters,
      V4_SystemSecurityGroupMaint_Request request,
      out V4_SystemSecurityGroupMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      V4_SystemSecurityGroupMaint v4_SystemSecurityGroupMaint,
      V4_SystemSecurityGroupMaint_LoadESigDetails_Parameters parameters,
      V4_SystemSecurityGroupMaint_Request request,
      out V4_SystemSecurityGroupMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      V4_SystemSecurityGroupMaint v4_SystemSecurityGroupMaint,
      V4_SystemSecurityGroupMaint_Parameters parameters,
      V4_SystemSecurityGroupMaint_Request request,
      out V4_SystemSecurityGroupMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      V4_SystemSecurityGroupMaint v4_SystemSecurityGroupMaint,
      V4_SystemSecurityGroupMaint_Parameters parameters,
      V4_SystemSecurityGroupMaint_Request request,
      out V4_SystemSecurityGroupMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      V4_SystemSecurityGroupMaint v4_SystemSecurityGroupMaint,
      V4_SystemSecurityGroupMaint_Parameters parameters,
      V4_SystemSecurityGroupMaint_Request request,
      out V4_SystemSecurityGroupMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      V4_SystemSecurityGroupMaint v4_SystemSecurityGroupMaint,
      V4_SystemSecurityGroupMaint_Parameters parameters,
      V4_SystemSecurityGroupMaint_Request request,
      out V4_SystemSecurityGroupMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      V4_SystemSecurityGroupMaintMethod[] methods,
      V4_SystemSecurityGroupMaint_Request request,
      out V4_SystemSecurityGroupMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      V4_SystemSecurityGroupMaint v4_SystemSecurityGroupMaint,
      V4_SystemSecurityGroupMaint_Request request,
      out V4_SystemSecurityGroupMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      V4_SystemSecurityGroupMaint v4_SystemSecurityGroupMaint,
      V4_SystemSecurityGroupMaint_Request request,
      out V4_SystemSecurityGroupMaint_Result result);
  }
}
