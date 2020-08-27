// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.TextVariableMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class TextVariableMaintService : NamedDataObjectMaintBase
  {
    public TextVariableMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (ITextVariableMaintService), userProfile);
    }

    public ResultStatus Delete(
      TextVariableMaint textVariableMaint,
      TextVariableMaint_Parameters parameters,
      TextVariableMaint_Request request,
      out TextVariableMaint_Result result)
    {
      result = (TextVariableMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) textVariableMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITextVariableMaintService) this._Channel).Delete(this._UserProfile, textVariableMaint, parameters, request, out result) : this.AddMethod((Method) new TextVariableMaintMethod(textVariableMaint, TextVariableMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) textVariableMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((TextVariableMaint) null, (TextVariableMaint_Parameters) null, (TextVariableMaint_Request) null, out TextVariableMaint_Result _);
    }

    public ResultStatus Delete(TextVariableMaint textVariableMaint)
    {
      return this.Delete(textVariableMaint, (TextVariableMaint_Parameters) null, (TextVariableMaint_Request) null, out TextVariableMaint_Result _);
    }

    public ResultStatus Delete(
      TextVariableMaint textVariableMaint,
      TextVariableMaint_Request request,
      out TextVariableMaint_Result result)
    {
      return this.Delete(textVariableMaint, (TextVariableMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      TextVariableMaint textVariableMaint,
      TextVariableMaint_Parameters parameters,
      TextVariableMaint_Request request,
      out TextVariableMaint_Result result)
    {
      result = (TextVariableMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) textVariableMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITextVariableMaintService) this._Channel).Freeze(this._UserProfile, textVariableMaint, parameters, request, out result) : this.AddMethod((Method) new TextVariableMaintMethod(textVariableMaint, TextVariableMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) textVariableMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((TextVariableMaint) null, (TextVariableMaint_Parameters) null, (TextVariableMaint_Request) null, out TextVariableMaint_Result _);
    }

    public ResultStatus Freeze(TextVariableMaint textVariableMaint)
    {
      return this.Freeze(textVariableMaint, (TextVariableMaint_Parameters) null, (TextVariableMaint_Request) null, out TextVariableMaint_Result _);
    }

    public ResultStatus Freeze(
      TextVariableMaint textVariableMaint,
      TextVariableMaint_Request request,
      out TextVariableMaint_Result result)
    {
      return this.Freeze(textVariableMaint, (TextVariableMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      TextVariableMaint textVariableMaint,
      TextVariableMaint_Parameters parameters,
      TextVariableMaint_Request request,
      out TextVariableMaint_Result result)
    {
      result = (TextVariableMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) textVariableMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITextVariableMaintService) this._Channel).GetWIPMsgs(this._UserProfile, textVariableMaint, parameters, request, out result) : this.AddMethod((Method) new TextVariableMaintMethod(textVariableMaint, TextVariableMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) textVariableMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((TextVariableMaint) null, (TextVariableMaint_Parameters) null, (TextVariableMaint_Request) null, out TextVariableMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(TextVariableMaint textVariableMaint)
    {
      return this.GetWIPMsgs(textVariableMaint, (TextVariableMaint_Parameters) null, (TextVariableMaint_Request) null, out TextVariableMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      TextVariableMaint textVariableMaint,
      TextVariableMaint_Request request,
      out TextVariableMaint_Result result)
    {
      return this.GetWIPMsgs(textVariableMaint, (TextVariableMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      TextVariableMaint textVariableMaint,
      TextVariableMaint_Parameters parameters,
      TextVariableMaint_Request request,
      out TextVariableMaint_Result result)
    {
      result = (TextVariableMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) textVariableMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITextVariableMaintService) this._Channel).Load(this._UserProfile, textVariableMaint, parameters, request, out result) : this.AddMethod((Method) new TextVariableMaintMethod(textVariableMaint, TextVariableMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) textVariableMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((TextVariableMaint) null, (TextVariableMaint_Parameters) null, (TextVariableMaint_Request) null, out TextVariableMaint_Result _);
    }

    public ResultStatus Load(TextVariableMaint textVariableMaint)
    {
      return this.Load(textVariableMaint, (TextVariableMaint_Parameters) null, (TextVariableMaint_Request) null, out TextVariableMaint_Result _);
    }

    public ResultStatus Load(
      TextVariableMaint textVariableMaint,
      TextVariableMaint_Request request,
      out TextVariableMaint_Result result)
    {
      return this.Load(textVariableMaint, (TextVariableMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      TextVariableMaint textVariableMaint,
      TextVariableMaint_LoadESigDetails_Parameters parameters,
      TextVariableMaint_Request request,
      out TextVariableMaint_Result result)
    {
      result = (TextVariableMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) textVariableMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITextVariableMaintService) this._Channel).LoadESigDetails(this._UserProfile, textVariableMaint, parameters, request, out result) : this.AddMethod((Method) new TextVariableMaintMethod(textVariableMaint, TextVariableMaintMethods.LoadESigDetails, (TextVariableMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) textVariableMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((TextVariableMaint) null, (TextVariableMaint_LoadESigDetails_Parameters) null, (TextVariableMaint_Request) null, out TextVariableMaint_Result _);
    }

    public ResultStatus LoadESigDetails(TextVariableMaint textVariableMaint)
    {
      return this.LoadESigDetails(textVariableMaint, (TextVariableMaint_LoadESigDetails_Parameters) null, (TextVariableMaint_Request) null, out TextVariableMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      TextVariableMaint textVariableMaint,
      TextVariableMaint_Request request,
      out TextVariableMaint_Result result)
    {
      return this.LoadESigDetails(textVariableMaint, (TextVariableMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      TextVariableMaint textVariableMaint,
      TextVariableMaint_Parameters parameters,
      TextVariableMaint_Request request,
      out TextVariableMaint_Result result)
    {
      result = (TextVariableMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) textVariableMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITextVariableMaintService) this._Channel).New(this._UserProfile, textVariableMaint, parameters, request, out result) : this.AddMethod((Method) new TextVariableMaintMethod(textVariableMaint, TextVariableMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) textVariableMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((TextVariableMaint) null, (TextVariableMaint_Parameters) null, (TextVariableMaint_Request) null, out TextVariableMaint_Result _);
    }

    public ResultStatus New(TextVariableMaint textVariableMaint)
    {
      return this.New(textVariableMaint, (TextVariableMaint_Parameters) null, (TextVariableMaint_Request) null, out TextVariableMaint_Result _);
    }

    public ResultStatus New(
      TextVariableMaint textVariableMaint,
      TextVariableMaint_Request request,
      out TextVariableMaint_Result result)
    {
      return this.New(textVariableMaint, (TextVariableMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      TextVariableMaint textVariableMaint,
      TextVariableMaint_Parameters parameters,
      TextVariableMaint_Request request,
      out TextVariableMaint_Result result)
    {
      result = (TextVariableMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) textVariableMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITextVariableMaintService) this._Channel).NewCopy(this._UserProfile, textVariableMaint, parameters, request, out result) : this.AddMethod((Method) new TextVariableMaintMethod(textVariableMaint, TextVariableMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) textVariableMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((TextVariableMaint) null, (TextVariableMaint_Parameters) null, (TextVariableMaint_Request) null, out TextVariableMaint_Result _);
    }

    public ResultStatus NewCopy(TextVariableMaint textVariableMaint)
    {
      return this.NewCopy(textVariableMaint, (TextVariableMaint_Parameters) null, (TextVariableMaint_Request) null, out TextVariableMaint_Result _);
    }

    public ResultStatus NewCopy(
      TextVariableMaint textVariableMaint,
      TextVariableMaint_Request request,
      out TextVariableMaint_Result result)
    {
      return this.NewCopy(textVariableMaint, (TextVariableMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      TextVariableMaint textVariableMaint,
      TextVariableMaint_Parameters parameters,
      TextVariableMaint_Request request,
      out TextVariableMaint_Result result)
    {
      result = (TextVariableMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) textVariableMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITextVariableMaintService) this._Channel).SaveAs(this._UserProfile, textVariableMaint, parameters, request, out result) : this.AddMethod((Method) new TextVariableMaintMethod(textVariableMaint, TextVariableMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) textVariableMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((TextVariableMaint) null, (TextVariableMaint_Parameters) null, (TextVariableMaint_Request) null, out TextVariableMaint_Result _);
    }

    public ResultStatus SaveAs(TextVariableMaint textVariableMaint)
    {
      return this.SaveAs(textVariableMaint, (TextVariableMaint_Parameters) null, (TextVariableMaint_Request) null, out TextVariableMaint_Result _);
    }

    public ResultStatus SaveAs(
      TextVariableMaint textVariableMaint,
      TextVariableMaint_Request request,
      out TextVariableMaint_Result result)
    {
      return this.SaveAs(textVariableMaint, (TextVariableMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      TextVariableMaint textVariableMaint,
      TextVariableMaint_Parameters parameters,
      TextVariableMaint_Request request,
      out TextVariableMaint_Result result)
    {
      result = (TextVariableMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) textVariableMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITextVariableMaintService) this._Channel).UnFreeze(this._UserProfile, textVariableMaint, parameters, request, out result) : this.AddMethod((Method) new TextVariableMaintMethod(textVariableMaint, TextVariableMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) textVariableMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((TextVariableMaint) null, (TextVariableMaint_Parameters) null, (TextVariableMaint_Request) null, out TextVariableMaint_Result _);
    }

    public ResultStatus UnFreeze(TextVariableMaint textVariableMaint)
    {
      return this.UnFreeze(textVariableMaint, (TextVariableMaint_Parameters) null, (TextVariableMaint_Request) null, out TextVariableMaint_Result _);
    }

    public ResultStatus UnFreeze(
      TextVariableMaint textVariableMaint,
      TextVariableMaint_Request request,
      out TextVariableMaint_Result result)
    {
      return this.UnFreeze(textVariableMaint, (TextVariableMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject textVariableMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TextVariableMaint_Result result1;
        ResultStatus resultStatus = this.Delete((TextVariableMaint) textVariableMaint, (TextVariableMaint_Parameters) parameters, (TextVariableMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject textVariableMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TextVariableMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((TextVariableMaint) textVariableMaint, (TextVariableMaint_Parameters) parameters, (TextVariableMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject textVariableMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TextVariableMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((TextVariableMaint) textVariableMaint, (TextVariableMaint_LoadESigDetails_Parameters) parameters, (TextVariableMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject textVariableMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TextVariableMaint_Result result1;
        ResultStatus resultStatus = this.New((TextVariableMaint) textVariableMaint, (TextVariableMaint_Parameters) parameters, (TextVariableMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject textVariableMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TextVariableMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((TextVariableMaint) textVariableMaint, (TextVariableMaint_Parameters) parameters, (TextVariableMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject textVariableMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TextVariableMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((TextVariableMaint) textVariableMaint, (TextVariableMaint_Parameters) parameters, (TextVariableMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject textVariableMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TextVariableMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((TextVariableMaint) textVariableMaint, (TextVariableMaint_Parameters) parameters, (TextVariableMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject textVariableMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TextVariableMaint_Result result1;
        ResultStatus resultStatus = this.Load((TextVariableMaint) textVariableMaint, (TextVariableMaint_Parameters) parameters, (TextVariableMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject textVariableMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TextVariableMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((TextVariableMaint) textVariableMaint, (TextVariableMaint_Parameters) parameters, (TextVariableMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      TextVariableMaint_Request request,
      out TextVariableMaint_Result result)
    {
      result = (TextVariableMaint_Result) null;
      try
      {
        TextVariableMaintMethod[] methods = new TextVariableMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((ITextVariableMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        TextVariableMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((TextVariableMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      TextVariableMaint cdo,
      TextVariableMaint_Request request,
      out TextVariableMaint_Result result)
    {
      result = (TextVariableMaint_Result) null;
      try
      {
        return ((ITextVariableMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        TextVariableMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((TextVariableMaint) cdo, (TextVariableMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      TextVariableMaint_Request request,
      out TextVariableMaint_Result result)
    {
      return this.GetEnvironment((TextVariableMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      TextVariableMaint cdo,
      TextVariableMaint_Request request,
      out TextVariableMaint_Result result)
    {
      result = (TextVariableMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITextVariableMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new TextVariableMaintMethod(cdo, TextVariableMaintMethods.ExecuteTransaction, (TextVariableMaint_Parameters) null));
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
        TextVariableMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((TextVariableMaint) cdo, (TextVariableMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(TextVariableMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (TextVariableMaint_Request) null, out TextVariableMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      TextVariableMaint_Request request,
      out TextVariableMaint_Result result)
    {
      return this.ExecuteTransaction((TextVariableMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(TextVariableMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new TextVariableMaintMethod(cdo, TextVariableMaintMethods.AddDataTransaction, (TextVariableMaint_Parameters) null));
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
        return this.AddDataTransaction((TextVariableMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
