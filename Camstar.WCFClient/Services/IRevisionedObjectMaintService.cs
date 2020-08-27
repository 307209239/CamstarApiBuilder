// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IRevisionedObjectMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IRevisionedObjectMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      RevisionedObjectMaint revisionedObjectMaint,
      RevisionedObjectMaint_Parameters parameters,
      RevisionedObjectMaint_Request request,
      out RevisionedObjectMaint_Result result);

    [OperationContract]
    ResultStatus DeleteAllRevisions(
      UserProfile userProfile,
      RevisionedObjectMaint revisionedObjectMaint,
      RevisionedObjectMaint_Parameters parameters,
      RevisionedObjectMaint_Request request,
      out RevisionedObjectMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      RevisionedObjectMaint revisionedObjectMaint,
      RevisionedObjectMaint_Parameters parameters,
      RevisionedObjectMaint_Request request,
      out RevisionedObjectMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      RevisionedObjectMaint revisionedObjectMaint,
      RevisionedObjectMaint_Parameters parameters,
      RevisionedObjectMaint_Request request,
      out RevisionedObjectMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      RevisionedObjectMaint revisionedObjectMaint,
      RevisionedObjectMaint_Parameters parameters,
      RevisionedObjectMaint_Request request,
      out RevisionedObjectMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      RevisionedObjectMaint revisionedObjectMaint,
      RevisionedObjectMaint_LoadESigDetails_Parameters parameters,
      RevisionedObjectMaint_Request request,
      out RevisionedObjectMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      RevisionedObjectMaint revisionedObjectMaint,
      RevisionedObjectMaint_Parameters parameters,
      RevisionedObjectMaint_Request request,
      out RevisionedObjectMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      RevisionedObjectMaint revisionedObjectMaint,
      RevisionedObjectMaint_Parameters parameters,
      RevisionedObjectMaint_Request request,
      out RevisionedObjectMaint_Result result);

    [OperationContract]
    ResultStatus NewRev(
      UserProfile userProfile,
      RevisionedObjectMaint revisionedObjectMaint,
      RevisionedObjectMaint_Parameters parameters,
      RevisionedObjectMaint_Request request,
      out RevisionedObjectMaint_Result result);

    [OperationContract]
    ResultStatus NewRevCopy(
      UserProfile userProfile,
      RevisionedObjectMaint revisionedObjectMaint,
      RevisionedObjectMaint_Parameters parameters,
      RevisionedObjectMaint_Request request,
      out RevisionedObjectMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      RevisionedObjectMaint revisionedObjectMaint,
      RevisionedObjectMaint_Parameters parameters,
      RevisionedObjectMaint_Request request,
      out RevisionedObjectMaint_Result result);

    [OperationContract]
    ResultStatus SaveAsRev(
      UserProfile userProfile,
      RevisionedObjectMaint revisionedObjectMaint,
      RevisionedObjectMaint_Parameters parameters,
      RevisionedObjectMaint_Request request,
      out RevisionedObjectMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      RevisionedObjectMaint revisionedObjectMaint,
      RevisionedObjectMaint_Parameters parameters,
      RevisionedObjectMaint_Request request,
      out RevisionedObjectMaint_Result result);

    [OperationContract]
    ResultStatus ValidateLock(
      UserProfile userProfile,
      RevisionedObjectMaint revisionedObjectMaint,
      RevisionedObjectMaint_Parameters parameters,
      RevisionedObjectMaint_Request request,
      out RevisionedObjectMaint_Result result);

    [OperationContract]
    ResultStatus ValidateMasterDataCatalog(
      UserProfile userProfile,
      RevisionedObjectMaint revisionedObjectMaint,
      RevisionedObjectMaint_Parameters parameters,
      RevisionedObjectMaint_Request request,
      out RevisionedObjectMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      RevisionedObjectMaintMethod[] methods,
      RevisionedObjectMaint_Request request,
      out RevisionedObjectMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      RevisionedObjectMaint revisionedObjectMaint,
      RevisionedObjectMaint_Request request,
      out RevisionedObjectMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      RevisionedObjectMaint revisionedObjectMaint,
      RevisionedObjectMaint_Request request,
      out RevisionedObjectMaint_Result result);
  }
}
