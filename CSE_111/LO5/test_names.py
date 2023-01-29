from names import make_full_name, \
    extract_family_name, extract_given_name
import pytest

def test_make_full_name():
    """Tests make_full_name function"""

    assert make_full_name("Mike", "Helm") == "Helm; Mike"
    assert make_full_name("Oghenekome", "Igho") == "Igho; Oghenekome"
    assert make_full_name("Austin", "Judkins") == "Judkins; Austin"
    assert make_full_name("David", "Jackson") == "Jackson; David"
    assert make_full_name("Yun-Ting", "Chang") == "Chang; Yun-Ting"

def test_extract_family_name():

    assert extract_family_name("Helm; Mike") == "Helm"
    assert extract_family_name("Igho; Oghenekome") == "Igho"
    assert extract_family_name("Judkins; Austin") == "Judkins"
    assert extract_family_name("Jackson; David") == "Jackson"
    assert extract_family_name("Chang; Yun-Ting") == "Chang"

def test_extract_given_name():

    assert extract_given_name("Helm; Mike") == "Mike"
    assert extract_given_name("Igho; Oghenekome") == "Oghenekome"
    assert extract_given_name("Judkins; Austin") == "Austin"
    assert extract_given_name("Jackson; David") == "David"
    assert extract_given_name("Chang; Yun-Ting") == "Yun-Ting"

# Call the main function that is part of pytest so that the
# computer will execute the test functions in this file.
pytest.main(["-v", "--tb=line", "-rN", __file__])