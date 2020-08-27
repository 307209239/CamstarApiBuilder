// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IResourceFamilyMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IResourceFamilyMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      ResourceFamilyMaint resourceFamilyMaint,
      ResourceFamilyMaint_Parameters parameters,
      ResourceFamilyMaint_Request request,
      out ResourceFamilyMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      ResourceFamilyMaint resourceFamilyMaint,
      ResourceFamilyMaint_Parameters parameters,
      ResourceFamilyMaint_Request request,
      out ResourceFamilyMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ResourceFamilyMaint resourceFamilyMaint,
      ResourceFamilyMaint_Parameters parameters,
      ResourceFamilyMaint_Request request,
      out ResourceFamilyMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ResourceFamilyMaint resourceFamilyMaint,
      ResourceFamilyMaint_Parameters parameters,
      ResourceFamilyMaint_Request request,
      out ResourceFamilyMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ResourceFamilyMaint resourceFamilyMaint,
      ResourceFamilyMaint_LoadESigDetails_Parameters parameters,
      ResourceFamilyMaint_Request request,
      out ResourceFamilyMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      ResourceFamilyMaint resourceFamilyMaint,
      ResourceFamilyMaint_Parameters parameters,
      ResourceFamilyMaint_Request request,
      out ResourceFamilyMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      ResourceFamilyMaint resourceFamilyMaint,
      ResourceFamilyMaint_Parameters parameters,
      ResourceFamilyMaint_Request request,
      out ResourceFamilyMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      ResourceFamilyMaint resourceFamilyMaint,
      ResourceFamilyMaint_Parameters parameters,
      ResourceFamilyMaint_Request request,
      out ResourceFamilyMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      ResourceFamilyMaint resourceFamilyMaint,
      ResourceFamilyMaint_Parameters parameters,
      ResourceFamilyMaint_Request request,
      out ResourceFamilyMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ResourceFamilyMaintMethod[] methods,
      ResourceFamilyMaint_Request request,
      out ResourceFamilyMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ResourceFamilyMaint resourceFamilyMaint,
      ResourceFamilyMaint_Request request,
      out ResourceFamilyMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ResourceFamilyMaint resourceFamilyMaint,
      ResourceFamilyMaint_Request request,
      out ResourceFamilyMaint_Result result);
  }
}
