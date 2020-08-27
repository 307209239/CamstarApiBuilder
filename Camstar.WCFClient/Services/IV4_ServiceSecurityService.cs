// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IV4_ServiceSecurityService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IV4_ServiceSecurityService
  {
    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      V4_ServiceSecurity v4_ServiceSecurity,
      V4_ServiceSecurity_Parameters parameters,
      V4_ServiceSecurity_Request request,
      out V4_ServiceSecurity_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      V4_ServiceSecurity v4_ServiceSecurity,
      V4_ServiceSecurity_Parameters parameters,
      V4_ServiceSecurity_Request request,
      out V4_ServiceSecurity_Result result);

    [OperationContract]
    ResultStatus LoadPermissionsGroup(
      UserProfile userProfile,
      V4_ServiceSecurity v4_ServiceSecurity,
      V4_ServiceSecurity_Parameters parameters,
      V4_ServiceSecurity_Request request,
      out V4_ServiceSecurity_Result result);

    [OperationContract]
    ResultStatus LoadPermissionsUser(
      UserProfile userProfile,
      V4_ServiceSecurity v4_ServiceSecurity,
      V4_ServiceSecurity_Parameters parameters,
      V4_ServiceSecurity_Request request,
      out V4_ServiceSecurity_Result result);

    [OperationContract]
    ResultStatus PermissionsCopy(
      UserProfile userProfile,
      V4_ServiceSecurity v4_ServiceSecurity,
      V4_ServiceSecurity_Parameters parameters,
      V4_ServiceSecurity_Request request,
      out V4_ServiceSecurity_Result result);

    [OperationContract]
    ResultStatus Save(
      UserProfile userProfile,
      V4_ServiceSecurity v4_ServiceSecurity,
      V4_ServiceSecurity_Parameters parameters,
      V4_ServiceSecurity_Request request,
      out V4_ServiceSecurity_Result result);

    [OperationContract]
    ResultStatus SavePermissionsGroup(
      UserProfile userProfile,
      V4_ServiceSecurity v4_ServiceSecurity,
      V4_ServiceSecurity_Parameters parameters,
      V4_ServiceSecurity_Request request,
      out V4_ServiceSecurity_Result result);

    [OperationContract]
    ResultStatus SavePermissionsUser(
      UserProfile userProfile,
      V4_ServiceSecurity v4_ServiceSecurity,
      V4_ServiceSecurity_Parameters parameters,
      V4_ServiceSecurity_Request request,
      out V4_ServiceSecurity_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      V4_ServiceSecurityMethod[] methods,
      V4_ServiceSecurity_Request request,
      out V4_ServiceSecurity_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      V4_ServiceSecurity v4_ServiceSecurity,
      V4_ServiceSecurity_Request request,
      out V4_ServiceSecurity_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      V4_ServiceSecurity v4_ServiceSecurity,
      V4_ServiceSecurity_Request request,
      out V4_ServiceSecurity_Result result);
  }
}
