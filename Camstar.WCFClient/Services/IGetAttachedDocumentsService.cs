// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IGetAttachedDocumentsService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IGetAttachedDocumentsService
  {
    [OperationContract]
    ResultStatus GetAttachedDocuments_GetDocs(
      UserProfile userProfile,
      GetAttachedDocuments getAttachedDocuments,
      GetAttachedDocuments_Parameters parameters,
      GetAttachedDocuments_Request request,
      out GetAttachedDocuments_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      GetAttachedDocuments getAttachedDocuments,
      GetAttachedDocuments_Parameters parameters,
      GetAttachedDocuments_Request request,
      out GetAttachedDocuments_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      GetAttachedDocumentsMethod[] methods,
      GetAttachedDocuments_Request request,
      out GetAttachedDocuments_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      GetAttachedDocuments getAttachedDocuments,
      GetAttachedDocuments_Request request,
      out GetAttachedDocuments_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      GetAttachedDocuments getAttachedDocuments,
      GetAttachedDocuments_Request request,
      out GetAttachedDocuments_Result result);
  }
}
