// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IV4_ObjectTypeSecurityService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IV4_ObjectTypeSecurityService
  {
    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      V4_ObjectTypeSecurity v4_ObjectTypeSecurity,
      V4_ObjectTypeSecurity_Parameters parameters,
      V4_ObjectTypeSecurity_Request request,
      out V4_ObjectTypeSecurity_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      V4_ObjectTypeSecurity v4_ObjectTypeSecurity,
      V4_ObjectTypeSecurity_Parameters parameters,
      V4_ObjectTypeSecurity_Request request,
      out V4_ObjectTypeSecurity_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      V4_ObjectTypeSecurityMethod[] methods,
      V4_ObjectTypeSecurity_Request request,
      out V4_ObjectTypeSecurity_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      V4_ObjectTypeSecurity v4_ObjectTypeSecurity,
      V4_ObjectTypeSecurity_Request request,
      out V4_ObjectTypeSecurity_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      V4_ObjectTypeSecurity v4_ObjectTypeSecurity,
      V4_ObjectTypeSecurity_Request request,
      out V4_ObjectTypeSecurity_Result result);
  }
}
