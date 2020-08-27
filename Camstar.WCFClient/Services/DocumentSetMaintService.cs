// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.DocumentSetMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class DocumentSetMaintService : NamedDataObjectMaintBase
  {
    public DocumentSetMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IDocumentSetMaintService), userProfile);
    }

    public ResultStatus Delete(
      DocumentSetMaint documentSetMaint,
      DocumentSetMaint_Parameters parameters,
      DocumentSetMaint_Request request,
      out DocumentSetMaint_Result result)
    {
      result = (DocumentSetMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) documentSetMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDocumentSetMaintService) this._Channel).Delete(this._UserProfile, documentSetMaint, parameters, request, out result) : this.AddMethod((Method) new DocumentSetMaintMethod(documentSetMaint, DocumentSetMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) documentSetMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((DocumentSetMaint) null, (DocumentSetMaint_Parameters) null, (DocumentSetMaint_Request) null, out DocumentSetMaint_Result _);
    }

    public ResultStatus Delete(DocumentSetMaint documentSetMaint)
    {
      return this.Delete(documentSetMaint, (DocumentSetMaint_Parameters) null, (DocumentSetMaint_Request) null, out DocumentSetMaint_Result _);
    }

    public ResultStatus Delete(
      DocumentSetMaint documentSetMaint,
      DocumentSetMaint_Request request,
      out DocumentSetMaint_Result result)
    {
      return this.Delete(documentSetMaint, (DocumentSetMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      DocumentSetMaint documentSetMaint,
      DocumentSetMaint_Parameters parameters,
      DocumentSetMaint_Request request,
      out DocumentSetMaint_Result result)
    {
      result = (DocumentSetMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) documentSetMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDocumentSetMaintService) this._Channel).Freeze(this._UserProfile, documentSetMaint, parameters, request, out result) : this.AddMethod((Method) new DocumentSetMaintMethod(documentSetMaint, DocumentSetMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) documentSetMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((DocumentSetMaint) null, (DocumentSetMaint_Parameters) null, (DocumentSetMaint_Request) null, out DocumentSetMaint_Result _);
    }

    public ResultStatus Freeze(DocumentSetMaint documentSetMaint)
    {
      return this.Freeze(documentSetMaint, (DocumentSetMaint_Parameters) null, (DocumentSetMaint_Request) null, out DocumentSetMaint_Result _);
    }

    public ResultStatus Freeze(
      DocumentSetMaint documentSetMaint,
      DocumentSetMaint_Request request,
      out DocumentSetMaint_Result result)
    {
      return this.Freeze(documentSetMaint, (DocumentSetMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      DocumentSetMaint documentSetMaint,
      DocumentSetMaint_Parameters parameters,
      DocumentSetMaint_Request request,
      out DocumentSetMaint_Result result)
    {
      result = (DocumentSetMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) documentSetMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDocumentSetMaintService) this._Channel).GetWIPMsgs(this._UserProfile, documentSetMaint, parameters, request, out result) : this.AddMethod((Method) new DocumentSetMaintMethod(documentSetMaint, DocumentSetMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) documentSetMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((DocumentSetMaint) null, (DocumentSetMaint_Parameters) null, (DocumentSetMaint_Request) null, out DocumentSetMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(DocumentSetMaint documentSetMaint)
    {
      return this.GetWIPMsgs(documentSetMaint, (DocumentSetMaint_Parameters) null, (DocumentSetMaint_Request) null, out DocumentSetMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      DocumentSetMaint documentSetMaint,
      DocumentSetMaint_Request request,
      out DocumentSetMaint_Result result)
    {
      return this.GetWIPMsgs(documentSetMaint, (DocumentSetMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      DocumentSetMaint documentSetMaint,
      DocumentSetMaint_Parameters parameters,
      DocumentSetMaint_Request request,
      out DocumentSetMaint_Result result)
    {
      result = (DocumentSetMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) documentSetMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDocumentSetMaintService) this._Channel).Load(this._UserProfile, documentSetMaint, parameters, request, out result) : this.AddMethod((Method) new DocumentSetMaintMethod(documentSetMaint, DocumentSetMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) documentSetMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((DocumentSetMaint) null, (DocumentSetMaint_Parameters) null, (DocumentSetMaint_Request) null, out DocumentSetMaint_Result _);
    }

    public ResultStatus Load(DocumentSetMaint documentSetMaint)
    {
      return this.Load(documentSetMaint, (DocumentSetMaint_Parameters) null, (DocumentSetMaint_Request) null, out DocumentSetMaint_Result _);
    }

    public ResultStatus Load(
      DocumentSetMaint documentSetMaint,
      DocumentSetMaint_Request request,
      out DocumentSetMaint_Result result)
    {
      return this.Load(documentSetMaint, (DocumentSetMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      DocumentSetMaint documentSetMaint,
      DocumentSetMaint_LoadESigDetails_Parameters parameters,
      DocumentSetMaint_Request request,
      out DocumentSetMaint_Result result)
    {
      result = (DocumentSetMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) documentSetMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDocumentSetMaintService) this._Channel).LoadESigDetails(this._UserProfile, documentSetMaint, parameters, request, out result) : this.AddMethod((Method) new DocumentSetMaintMethod(documentSetMaint, DocumentSetMaintMethods.LoadESigDetails, (DocumentSetMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) documentSetMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((DocumentSetMaint) null, (DocumentSetMaint_LoadESigDetails_Parameters) null, (DocumentSetMaint_Request) null, out DocumentSetMaint_Result _);
    }

    public ResultStatus LoadESigDetails(DocumentSetMaint documentSetMaint)
    {
      return this.LoadESigDetails(documentSetMaint, (DocumentSetMaint_LoadESigDetails_Parameters) null, (DocumentSetMaint_Request) null, out DocumentSetMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      DocumentSetMaint documentSetMaint,
      DocumentSetMaint_Request request,
      out DocumentSetMaint_Result result)
    {
      return this.LoadESigDetails(documentSetMaint, (DocumentSetMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      DocumentSetMaint documentSetMaint,
      DocumentSetMaint_Parameters parameters,
      DocumentSetMaint_Request request,
      out DocumentSetMaint_Result result)
    {
      result = (DocumentSetMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) documentSetMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDocumentSetMaintService) this._Channel).New(this._UserProfile, documentSetMaint, parameters, request, out result) : this.AddMethod((Method) new DocumentSetMaintMethod(documentSetMaint, DocumentSetMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) documentSetMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((DocumentSetMaint) null, (DocumentSetMaint_Parameters) null, (DocumentSetMaint_Request) null, out DocumentSetMaint_Result _);
    }

    public ResultStatus New(DocumentSetMaint documentSetMaint)
    {
      return this.New(documentSetMaint, (DocumentSetMaint_Parameters) null, (DocumentSetMaint_Request) null, out DocumentSetMaint_Result _);
    }

    public ResultStatus New(
      DocumentSetMaint documentSetMaint,
      DocumentSetMaint_Request request,
      out DocumentSetMaint_Result result)
    {
      return this.New(documentSetMaint, (DocumentSetMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      DocumentSetMaint documentSetMaint,
      DocumentSetMaint_Parameters parameters,
      DocumentSetMaint_Request request,
      out DocumentSetMaint_Result result)
    {
      result = (DocumentSetMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) documentSetMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDocumentSetMaintService) this._Channel).NewCopy(this._UserProfile, documentSetMaint, parameters, request, out result) : this.AddMethod((Method) new DocumentSetMaintMethod(documentSetMaint, DocumentSetMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) documentSetMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((DocumentSetMaint) null, (DocumentSetMaint_Parameters) null, (DocumentSetMaint_Request) null, out DocumentSetMaint_Result _);
    }

    public ResultStatus NewCopy(DocumentSetMaint documentSetMaint)
    {
      return this.NewCopy(documentSetMaint, (DocumentSetMaint_Parameters) null, (DocumentSetMaint_Request) null, out DocumentSetMaint_Result _);
    }

    public ResultStatus NewCopy(
      DocumentSetMaint documentSetMaint,
      DocumentSetMaint_Request request,
      out DocumentSetMaint_Result result)
    {
      return this.NewCopy(documentSetMaint, (DocumentSetMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      DocumentSetMaint documentSetMaint,
      DocumentSetMaint_Parameters parameters,
      DocumentSetMaint_Request request,
      out DocumentSetMaint_Result result)
    {
      result = (DocumentSetMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) documentSetMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDocumentSetMaintService) this._Channel).SaveAs(this._UserProfile, documentSetMaint, parameters, request, out result) : this.AddMethod((Method) new DocumentSetMaintMethod(documentSetMaint, DocumentSetMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) documentSetMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((DocumentSetMaint) null, (DocumentSetMaint_Parameters) null, (DocumentSetMaint_Request) null, out DocumentSetMaint_Result _);
    }

    public ResultStatus SaveAs(DocumentSetMaint documentSetMaint)
    {
      return this.SaveAs(documentSetMaint, (DocumentSetMaint_Parameters) null, (DocumentSetMaint_Request) null, out DocumentSetMaint_Result _);
    }

    public ResultStatus SaveAs(
      DocumentSetMaint documentSetMaint,
      DocumentSetMaint_Request request,
      out DocumentSetMaint_Result result)
    {
      return this.SaveAs(documentSetMaint, (DocumentSetMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      DocumentSetMaint documentSetMaint,
      DocumentSetMaint_Parameters parameters,
      DocumentSetMaint_Request request,
      out DocumentSetMaint_Result result)
    {
      result = (DocumentSetMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) documentSetMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDocumentSetMaintService) this._Channel).UnFreeze(this._UserProfile, documentSetMaint, parameters, request, out result) : this.AddMethod((Method) new DocumentSetMaintMethod(documentSetMaint, DocumentSetMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) documentSetMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((DocumentSetMaint) null, (DocumentSetMaint_Parameters) null, (DocumentSetMaint_Request) null, out DocumentSetMaint_Result _);
    }

    public ResultStatus UnFreeze(DocumentSetMaint documentSetMaint)
    {
      return this.UnFreeze(documentSetMaint, (DocumentSetMaint_Parameters) null, (DocumentSetMaint_Request) null, out DocumentSetMaint_Result _);
    }

    public ResultStatus UnFreeze(
      DocumentSetMaint documentSetMaint,
      DocumentSetMaint_Request request,
      out DocumentSetMaint_Result result)
    {
      return this.UnFreeze(documentSetMaint, (DocumentSetMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject documentSetMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DocumentSetMaint_Result result1;
        ResultStatus resultStatus = this.Delete((DocumentSetMaint) documentSetMaint, (DocumentSetMaint_Parameters) parameters, (DocumentSetMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject documentSetMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DocumentSetMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((DocumentSetMaint) documentSetMaint, (DocumentSetMaint_Parameters) parameters, (DocumentSetMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject documentSetMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DocumentSetMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((DocumentSetMaint) documentSetMaint, (DocumentSetMaint_LoadESigDetails_Parameters) parameters, (DocumentSetMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject documentSetMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DocumentSetMaint_Result result1;
        ResultStatus resultStatus = this.New((DocumentSetMaint) documentSetMaint, (DocumentSetMaint_Parameters) parameters, (DocumentSetMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject documentSetMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DocumentSetMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((DocumentSetMaint) documentSetMaint, (DocumentSetMaint_Parameters) parameters, (DocumentSetMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject documentSetMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DocumentSetMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((DocumentSetMaint) documentSetMaint, (DocumentSetMaint_Parameters) parameters, (DocumentSetMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject documentSetMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DocumentSetMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((DocumentSetMaint) documentSetMaint, (DocumentSetMaint_Parameters) parameters, (DocumentSetMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject documentSetMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DocumentSetMaint_Result result1;
        ResultStatus resultStatus = this.Load((DocumentSetMaint) documentSetMaint, (DocumentSetMaint_Parameters) parameters, (DocumentSetMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject documentSetMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DocumentSetMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((DocumentSetMaint) documentSetMaint, (DocumentSetMaint_Parameters) parameters, (DocumentSetMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      DocumentSetMaint_Request request,
      out DocumentSetMaint_Result result)
    {
      result = (DocumentSetMaint_Result) null;
      try
      {
        DocumentSetMaintMethod[] methods = new DocumentSetMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IDocumentSetMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnCommitTransaction(
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DocumentSetMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((DocumentSetMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      DocumentSetMaint cdo,
      DocumentSetMaint_Request request,
      out DocumentSetMaint_Result result)
    {
      result = (DocumentSetMaint_Result) null;
      try
      {
        return ((IDocumentSetMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetEnvironment(
      DCObject cdo,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DocumentSetMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((DocumentSetMaint) cdo, (DocumentSetMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      DocumentSetMaint_Request request,
      out DocumentSetMaint_Result result)
    {
      return this.GetEnvironment((DocumentSetMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      DocumentSetMaint cdo,
      DocumentSetMaint_Request request,
      out DocumentSetMaint_Result result)
    {
      result = (DocumentSetMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDocumentSetMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new DocumentSetMaintMethod(cdo, DocumentSetMaintMethods.ExecuteTransaction, (DocumentSetMaint_Parameters) null));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ExecuteTransaction), res, (DCObject) cdo, (Parameters) null, (Request) request, (Result) result);
      return res;
    }

    protected override ResultStatus OnExecuteTransaction(
      DCObject cdo,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DocumentSetMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((DocumentSetMaint) cdo, (DocumentSetMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(DocumentSetMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (DocumentSetMaint_Request) null, out DocumentSetMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      DocumentSetMaint_Request request,
      out DocumentSetMaint_Result result)
    {
      return this.ExecuteTransaction((DocumentSetMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(DocumentSetMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new DocumentSetMaintMethod(cdo, DocumentSetMaintMethods.AddDataTransaction, (DocumentSetMaint_Parameters) null));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
      {
        Result result;
        this.OnAfterCall(nameof (AddDataTransaction), res, (DCObject) cdo, (Parameters) null, (Request) null, result);
      }
      return res;
    }

    protected override ResultStatus OnAddDataTransaction(DCObject cdo)
    {
      try
      {
        return this.AddDataTransaction((DocumentSetMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
