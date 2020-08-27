// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.RevisionedObjectGroupMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class RevisionedObjectGroupMaintService : ObjectGroupMaintBase
  {
    public RevisionedObjectGroupMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IRevisionedObjectGroupMaintService), userProfile);
    }

    public ResultStatus Delete(
      RevisionedObjectGroupMaint revisionedObjectGroupMaint,
      RevisionedObjectGroupMaint_Parameters parameters,
      RevisionedObjectGroupMaint_Request request,
      out RevisionedObjectGroupMaint_Result result)
    {
      result = (RevisionedObjectGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) revisionedObjectGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRevisionedObjectGroupMaintService) this._Channel).Delete(this._UserProfile, revisionedObjectGroupMaint, parameters, request, out result) : this.AddMethod((Method) new RevisionedObjectGroupMaintMethod(revisionedObjectGroupMaint, RevisionedObjectGroupMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) revisionedObjectGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((RevisionedObjectGroupMaint) null, (RevisionedObjectGroupMaint_Parameters) null, (RevisionedObjectGroupMaint_Request) null, out RevisionedObjectGroupMaint_Result _);
    }

    public ResultStatus Delete(
      RevisionedObjectGroupMaint revisionedObjectGroupMaint)
    {
      return this.Delete(revisionedObjectGroupMaint, (RevisionedObjectGroupMaint_Parameters) null, (RevisionedObjectGroupMaint_Request) null, out RevisionedObjectGroupMaint_Result _);
    }

    public ResultStatus Delete(
      RevisionedObjectGroupMaint revisionedObjectGroupMaint,
      RevisionedObjectGroupMaint_Request request,
      out RevisionedObjectGroupMaint_Result result)
    {
      return this.Delete(revisionedObjectGroupMaint, (RevisionedObjectGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      RevisionedObjectGroupMaint revisionedObjectGroupMaint,
      RevisionedObjectGroupMaint_Parameters parameters,
      RevisionedObjectGroupMaint_Request request,
      out RevisionedObjectGroupMaint_Result result)
    {
      result = (RevisionedObjectGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) revisionedObjectGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRevisionedObjectGroupMaintService) this._Channel).Freeze(this._UserProfile, revisionedObjectGroupMaint, parameters, request, out result) : this.AddMethod((Method) new RevisionedObjectGroupMaintMethod(revisionedObjectGroupMaint, RevisionedObjectGroupMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) revisionedObjectGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((RevisionedObjectGroupMaint) null, (RevisionedObjectGroupMaint_Parameters) null, (RevisionedObjectGroupMaint_Request) null, out RevisionedObjectGroupMaint_Result _);
    }

    public ResultStatus Freeze(
      RevisionedObjectGroupMaint revisionedObjectGroupMaint)
    {
      return this.Freeze(revisionedObjectGroupMaint, (RevisionedObjectGroupMaint_Parameters) null, (RevisionedObjectGroupMaint_Request) null, out RevisionedObjectGroupMaint_Result _);
    }

    public ResultStatus Freeze(
      RevisionedObjectGroupMaint revisionedObjectGroupMaint,
      RevisionedObjectGroupMaint_Request request,
      out RevisionedObjectGroupMaint_Result result)
    {
      return this.Freeze(revisionedObjectGroupMaint, (RevisionedObjectGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      RevisionedObjectGroupMaint revisionedObjectGroupMaint,
      RevisionedObjectGroupMaint_Parameters parameters,
      RevisionedObjectGroupMaint_Request request,
      out RevisionedObjectGroupMaint_Result result)
    {
      result = (RevisionedObjectGroupMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) revisionedObjectGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRevisionedObjectGroupMaintService) this._Channel).GetWIPMsgs(this._UserProfile, revisionedObjectGroupMaint, parameters, request, out result) : this.AddMethod((Method) new RevisionedObjectGroupMaintMethod(revisionedObjectGroupMaint, RevisionedObjectGroupMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) revisionedObjectGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((RevisionedObjectGroupMaint) null, (RevisionedObjectGroupMaint_Parameters) null, (RevisionedObjectGroupMaint_Request) null, out RevisionedObjectGroupMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      RevisionedObjectGroupMaint revisionedObjectGroupMaint)
    {
      return this.GetWIPMsgs(revisionedObjectGroupMaint, (RevisionedObjectGroupMaint_Parameters) null, (RevisionedObjectGroupMaint_Request) null, out RevisionedObjectGroupMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      RevisionedObjectGroupMaint revisionedObjectGroupMaint,
      RevisionedObjectGroupMaint_Request request,
      out RevisionedObjectGroupMaint_Result result)
    {
      return this.GetWIPMsgs(revisionedObjectGroupMaint, (RevisionedObjectGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      RevisionedObjectGroupMaint revisionedObjectGroupMaint,
      RevisionedObjectGroupMaint_Parameters parameters,
      RevisionedObjectGroupMaint_Request request,
      out RevisionedObjectGroupMaint_Result result)
    {
      result = (RevisionedObjectGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) revisionedObjectGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRevisionedObjectGroupMaintService) this._Channel).Load(this._UserProfile, revisionedObjectGroupMaint, parameters, request, out result) : this.AddMethod((Method) new RevisionedObjectGroupMaintMethod(revisionedObjectGroupMaint, RevisionedObjectGroupMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) revisionedObjectGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((RevisionedObjectGroupMaint) null, (RevisionedObjectGroupMaint_Parameters) null, (RevisionedObjectGroupMaint_Request) null, out RevisionedObjectGroupMaint_Result _);
    }

    public ResultStatus Load(
      RevisionedObjectGroupMaint revisionedObjectGroupMaint)
    {
      return this.Load(revisionedObjectGroupMaint, (RevisionedObjectGroupMaint_Parameters) null, (RevisionedObjectGroupMaint_Request) null, out RevisionedObjectGroupMaint_Result _);
    }

    public ResultStatus Load(
      RevisionedObjectGroupMaint revisionedObjectGroupMaint,
      RevisionedObjectGroupMaint_Request request,
      out RevisionedObjectGroupMaint_Result result)
    {
      return this.Load(revisionedObjectGroupMaint, (RevisionedObjectGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      RevisionedObjectGroupMaint revisionedObjectGroupMaint,
      RevisionedObjectGroupMaint_LoadESigDetails_Parameters parameters,
      RevisionedObjectGroupMaint_Request request,
      out RevisionedObjectGroupMaint_Result result)
    {
      result = (RevisionedObjectGroupMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) revisionedObjectGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRevisionedObjectGroupMaintService) this._Channel).LoadESigDetails(this._UserProfile, revisionedObjectGroupMaint, parameters, request, out result) : this.AddMethod((Method) new RevisionedObjectGroupMaintMethod(revisionedObjectGroupMaint, RevisionedObjectGroupMaintMethods.LoadESigDetails, (RevisionedObjectGroupMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) revisionedObjectGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((RevisionedObjectGroupMaint) null, (RevisionedObjectGroupMaint_LoadESigDetails_Parameters) null, (RevisionedObjectGroupMaint_Request) null, out RevisionedObjectGroupMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      RevisionedObjectGroupMaint revisionedObjectGroupMaint)
    {
      return this.LoadESigDetails(revisionedObjectGroupMaint, (RevisionedObjectGroupMaint_LoadESigDetails_Parameters) null, (RevisionedObjectGroupMaint_Request) null, out RevisionedObjectGroupMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      RevisionedObjectGroupMaint revisionedObjectGroupMaint,
      RevisionedObjectGroupMaint_Request request,
      out RevisionedObjectGroupMaint_Result result)
    {
      return this.LoadESigDetails(revisionedObjectGroupMaint, (RevisionedObjectGroupMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      RevisionedObjectGroupMaint revisionedObjectGroupMaint,
      RevisionedObjectGroupMaint_Parameters parameters,
      RevisionedObjectGroupMaint_Request request,
      out RevisionedObjectGroupMaint_Result result)
    {
      result = (RevisionedObjectGroupMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) revisionedObjectGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRevisionedObjectGroupMaintService) this._Channel).New(this._UserProfile, revisionedObjectGroupMaint, parameters, request, out result) : this.AddMethod((Method) new RevisionedObjectGroupMaintMethod(revisionedObjectGroupMaint, RevisionedObjectGroupMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) revisionedObjectGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((RevisionedObjectGroupMaint) null, (RevisionedObjectGroupMaint_Parameters) null, (RevisionedObjectGroupMaint_Request) null, out RevisionedObjectGroupMaint_Result _);
    }

    public ResultStatus New(
      RevisionedObjectGroupMaint revisionedObjectGroupMaint)
    {
      return this.New(revisionedObjectGroupMaint, (RevisionedObjectGroupMaint_Parameters) null, (RevisionedObjectGroupMaint_Request) null, out RevisionedObjectGroupMaint_Result _);
    }

    public ResultStatus New(
      RevisionedObjectGroupMaint revisionedObjectGroupMaint,
      RevisionedObjectGroupMaint_Request request,
      out RevisionedObjectGroupMaint_Result result)
    {
      return this.New(revisionedObjectGroupMaint, (RevisionedObjectGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      RevisionedObjectGroupMaint revisionedObjectGroupMaint,
      RevisionedObjectGroupMaint_Parameters parameters,
      RevisionedObjectGroupMaint_Request request,
      out RevisionedObjectGroupMaint_Result result)
    {
      result = (RevisionedObjectGroupMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) revisionedObjectGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRevisionedObjectGroupMaintService) this._Channel).NewCopy(this._UserProfile, revisionedObjectGroupMaint, parameters, request, out result) : this.AddMethod((Method) new RevisionedObjectGroupMaintMethod(revisionedObjectGroupMaint, RevisionedObjectGroupMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) revisionedObjectGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((RevisionedObjectGroupMaint) null, (RevisionedObjectGroupMaint_Parameters) null, (RevisionedObjectGroupMaint_Request) null, out RevisionedObjectGroupMaint_Result _);
    }

    public ResultStatus NewCopy(
      RevisionedObjectGroupMaint revisionedObjectGroupMaint)
    {
      return this.NewCopy(revisionedObjectGroupMaint, (RevisionedObjectGroupMaint_Parameters) null, (RevisionedObjectGroupMaint_Request) null, out RevisionedObjectGroupMaint_Result _);
    }

    public ResultStatus NewCopy(
      RevisionedObjectGroupMaint revisionedObjectGroupMaint,
      RevisionedObjectGroupMaint_Request request,
      out RevisionedObjectGroupMaint_Result result)
    {
      return this.NewCopy(revisionedObjectGroupMaint, (RevisionedObjectGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      RevisionedObjectGroupMaint revisionedObjectGroupMaint,
      RevisionedObjectGroupMaint_Parameters parameters,
      RevisionedObjectGroupMaint_Request request,
      out RevisionedObjectGroupMaint_Result result)
    {
      result = (RevisionedObjectGroupMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) revisionedObjectGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRevisionedObjectGroupMaintService) this._Channel).SaveAs(this._UserProfile, revisionedObjectGroupMaint, parameters, request, out result) : this.AddMethod((Method) new RevisionedObjectGroupMaintMethod(revisionedObjectGroupMaint, RevisionedObjectGroupMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) revisionedObjectGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((RevisionedObjectGroupMaint) null, (RevisionedObjectGroupMaint_Parameters) null, (RevisionedObjectGroupMaint_Request) null, out RevisionedObjectGroupMaint_Result _);
    }

    public ResultStatus SaveAs(
      RevisionedObjectGroupMaint revisionedObjectGroupMaint)
    {
      return this.SaveAs(revisionedObjectGroupMaint, (RevisionedObjectGroupMaint_Parameters) null, (RevisionedObjectGroupMaint_Request) null, out RevisionedObjectGroupMaint_Result _);
    }

    public ResultStatus SaveAs(
      RevisionedObjectGroupMaint revisionedObjectGroupMaint,
      RevisionedObjectGroupMaint_Request request,
      out RevisionedObjectGroupMaint_Result result)
    {
      return this.SaveAs(revisionedObjectGroupMaint, (RevisionedObjectGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      RevisionedObjectGroupMaint revisionedObjectGroupMaint,
      RevisionedObjectGroupMaint_Parameters parameters,
      RevisionedObjectGroupMaint_Request request,
      out RevisionedObjectGroupMaint_Result result)
    {
      result = (RevisionedObjectGroupMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) revisionedObjectGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRevisionedObjectGroupMaintService) this._Channel).UnFreeze(this._UserProfile, revisionedObjectGroupMaint, parameters, request, out result) : this.AddMethod((Method) new RevisionedObjectGroupMaintMethod(revisionedObjectGroupMaint, RevisionedObjectGroupMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) revisionedObjectGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((RevisionedObjectGroupMaint) null, (RevisionedObjectGroupMaint_Parameters) null, (RevisionedObjectGroupMaint_Request) null, out RevisionedObjectGroupMaint_Result _);
    }

    public ResultStatus UnFreeze(
      RevisionedObjectGroupMaint revisionedObjectGroupMaint)
    {
      return this.UnFreeze(revisionedObjectGroupMaint, (RevisionedObjectGroupMaint_Parameters) null, (RevisionedObjectGroupMaint_Request) null, out RevisionedObjectGroupMaint_Result _);
    }

    public ResultStatus UnFreeze(
      RevisionedObjectGroupMaint revisionedObjectGroupMaint,
      RevisionedObjectGroupMaint_Request request,
      out RevisionedObjectGroupMaint_Result result)
    {
      return this.UnFreeze(revisionedObjectGroupMaint, (RevisionedObjectGroupMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject revisionedObjectGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RevisionedObjectGroupMaint_Result result1;
        ResultStatus resultStatus = this.Delete((RevisionedObjectGroupMaint) revisionedObjectGroupMaint, (RevisionedObjectGroupMaint_Parameters) parameters, (RevisionedObjectGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject revisionedObjectGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RevisionedObjectGroupMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((RevisionedObjectGroupMaint) revisionedObjectGroupMaint, (RevisionedObjectGroupMaint_Parameters) parameters, (RevisionedObjectGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject revisionedObjectGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RevisionedObjectGroupMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((RevisionedObjectGroupMaint) revisionedObjectGroupMaint, (RevisionedObjectGroupMaint_LoadESigDetails_Parameters) parameters, (RevisionedObjectGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject revisionedObjectGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RevisionedObjectGroupMaint_Result result1;
        ResultStatus resultStatus = this.New((RevisionedObjectGroupMaint) revisionedObjectGroupMaint, (RevisionedObjectGroupMaint_Parameters) parameters, (RevisionedObjectGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject revisionedObjectGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RevisionedObjectGroupMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((RevisionedObjectGroupMaint) revisionedObjectGroupMaint, (RevisionedObjectGroupMaint_Parameters) parameters, (RevisionedObjectGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject revisionedObjectGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RevisionedObjectGroupMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((RevisionedObjectGroupMaint) revisionedObjectGroupMaint, (RevisionedObjectGroupMaint_Parameters) parameters, (RevisionedObjectGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject revisionedObjectGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RevisionedObjectGroupMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((RevisionedObjectGroupMaint) revisionedObjectGroupMaint, (RevisionedObjectGroupMaint_Parameters) parameters, (RevisionedObjectGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject revisionedObjectGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RevisionedObjectGroupMaint_Result result1;
        ResultStatus resultStatus = this.Load((RevisionedObjectGroupMaint) revisionedObjectGroupMaint, (RevisionedObjectGroupMaint_Parameters) parameters, (RevisionedObjectGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject revisionedObjectGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RevisionedObjectGroupMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((RevisionedObjectGroupMaint) revisionedObjectGroupMaint, (RevisionedObjectGroupMaint_Parameters) parameters, (RevisionedObjectGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      RevisionedObjectGroupMaint_Request request,
      out RevisionedObjectGroupMaint_Result result)
    {
      result = (RevisionedObjectGroupMaint_Result) null;
      try
      {
        RevisionedObjectGroupMaintMethod[] methods = new RevisionedObjectGroupMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IRevisionedObjectGroupMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        RevisionedObjectGroupMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((RevisionedObjectGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      RevisionedObjectGroupMaint cdo,
      RevisionedObjectGroupMaint_Request request,
      out RevisionedObjectGroupMaint_Result result)
    {
      result = (RevisionedObjectGroupMaint_Result) null;
      try
      {
        return ((IRevisionedObjectGroupMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        RevisionedObjectGroupMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((RevisionedObjectGroupMaint) cdo, (RevisionedObjectGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      RevisionedObjectGroupMaint_Request request,
      out RevisionedObjectGroupMaint_Result result)
    {
      return this.GetEnvironment((RevisionedObjectGroupMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      RevisionedObjectGroupMaint cdo,
      RevisionedObjectGroupMaint_Request request,
      out RevisionedObjectGroupMaint_Result result)
    {
      result = (RevisionedObjectGroupMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRevisionedObjectGroupMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new RevisionedObjectGroupMaintMethod(cdo, RevisionedObjectGroupMaintMethods.ExecuteTransaction, (RevisionedObjectGroupMaint_Parameters) null));
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
        RevisionedObjectGroupMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((RevisionedObjectGroupMaint) cdo, (RevisionedObjectGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(RevisionedObjectGroupMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (RevisionedObjectGroupMaint_Request) null, out RevisionedObjectGroupMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      RevisionedObjectGroupMaint_Request request,
      out RevisionedObjectGroupMaint_Result result)
    {
      return this.ExecuteTransaction((RevisionedObjectGroupMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(RevisionedObjectGroupMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new RevisionedObjectGroupMaintMethod(cdo, RevisionedObjectGroupMaintMethods.AddDataTransaction, (RevisionedObjectGroupMaint_Parameters) null));
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
        return this.AddDataTransaction((RevisionedObjectGroupMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
