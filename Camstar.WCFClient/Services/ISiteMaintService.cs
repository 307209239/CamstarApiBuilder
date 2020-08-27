// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ISiteMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface ISiteMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      SiteMaint siteMaint,
      SiteMaint_Parameters parameters,
      SiteMaint_Request request,
      out SiteMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      SiteMaint siteMaint,
      SiteMaint_Parameters parameters,
      SiteMaint_Request request,
      out SiteMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      SiteMaint siteMaint,
      SiteMaint_Parameters parameters,
      SiteMaint_Request request,
      out SiteMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      SiteMaint siteMaint,
      SiteMaint_Parameters parameters,
      SiteMaint_Request request,
      out SiteMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      SiteMaint siteMaint,
      SiteMaint_LoadESigDetails_Parameters parameters,
      SiteMaint_Request request,
      out SiteMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      SiteMaint siteMaint,
      SiteMaint_Parameters parameters,
      SiteMaint_Request request,
      out SiteMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      SiteMaint siteMaint,
      SiteMaint_Parameters parameters,
      SiteMaint_Request request,
      out SiteMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      SiteMaint siteMaint,
      SiteMaint_Parameters parameters,
      SiteMaint_Request request,
      out SiteMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      SiteMaint siteMaint,
      SiteMaint_Parameters parameters,
      SiteMaint_Request request,
      out SiteMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      SiteMaintMethod[] methods,
      SiteMaint_Request request,
      out SiteMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      SiteMaint siteMaint,
      SiteMaint_Request request,
      out SiteMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      SiteMaint siteMaint,
      SiteMaint_Request request,
      out SiteMaint_Result result);
  }
}
