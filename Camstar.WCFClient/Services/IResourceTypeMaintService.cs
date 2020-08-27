// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IResourceTypeMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IResourceTypeMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      ResourceTypeMaint resourceTypeMaint,
      ResourceTypeMaint_Parameters parameters,
      ResourceTypeMaint_Request request,
      out ResourceTypeMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      ResourceTypeMaint resourceTypeMaint,
      ResourceTypeMaint_Parameters parameters,
      ResourceTypeMaint_Request request,
      out ResourceTypeMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ResourceTypeMaint resourceTypeMaint,
      ResourceTypeMaint_Parameters parameters,
      ResourceTypeMaint_Request request,
      out ResourceTypeMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ResourceTypeMaint resourceTypeMaint,
      ResourceTypeMaint_Parameters parameters,
      ResourceTypeMaint_Request request,
      out ResourceTypeMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ResourceTypeMaint resourceTypeMaint,
      ResourceTypeMaint_LoadESigDetails_Parameters parameters,
      ResourceTypeMaint_Request request,
      out ResourceTypeMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      ResourceTypeMaint resourceTypeMaint,
      ResourceTypeMaint_Parameters parameters,
      ResourceTypeMaint_Request request,
      out ResourceTypeMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      ResourceTypeMaint resourceTypeMaint,
      ResourceTypeMaint_Parameters parameters,
      ResourceTypeMaint_Request request,
      out ResourceTypeMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      ResourceTypeMaint resourceTypeMaint,
      ResourceTypeMaint_Parameters parameters,
      ResourceTypeMaint_Request request,
      out ResourceTypeMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      ResourceTypeMaint resourceTypeMaint,
      ResourceTypeMaint_Parameters parameters,
      ResourceTypeMaint_Request request,
      out ResourceTypeMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ResourceTypeMaintMethod[] methods,
      ResourceTypeMaint_Request request,
      out ResourceTypeMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ResourceTypeMaint resourceTypeMaint,
      ResourceTypeMaint_Request request,
      out ResourceTypeMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ResourceTypeMaint resourceTypeMaint,
      ResourceTypeMaint_Request request,
      out ResourceTypeMaint_Result result);
  }
}
