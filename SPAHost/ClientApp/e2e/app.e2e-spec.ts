import { ABPFree_AngularTemplatePage } from './app.po';

describe('ABPFree_Angular App', function() {
  let page: ABPFree_AngularTemplatePage;

  beforeEach(() => {
    page = new ABPFree_AngularTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
